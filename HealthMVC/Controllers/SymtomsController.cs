using HealthMVC.Dto;
using HealthMVC.Models;
using HealthMVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HealthMVC.Controllers
{
    public class SymtomsController : Controller
    {
        private readonly SymtomService _symtomService;
        private readonly ConfigModel _configModel;
        private readonly HealthDbContext _healthDbContext;

        public SymtomsController(SymtomService symtomService, IOptions<ConfigModel> configModel, HealthDbContext healthDbContext)
        {
            _symtomService = symtomService;
            _configModel = configModel.Value;
            _healthDbContext = healthDbContext;
        }

        public async Task<IActionResult> Index()

        {
            var sym = await _symtomService.GetSymptoms(_configModel.Token, _configModel.language);
            return View(sym);
        }

        public async Task<IActionResult> Specilisation()

        {
            var spec = await _symtomService.GetSpecialisations(_configModel.Token, _configModel.language);
            var specialisation = spec.Select(specialisation => new Specialisation
            {
                Id = specialisation.Id,
                Name = specialisation.Name,
            }).ToList();
            await _healthDbContext.Specialisation.AddRangeAsync(specialisation);
            await _healthDbContext.SaveChangesAsync();
            return View(spec);
        }

        public async Task<IActionResult> Form()
        {
            var symList = await _symtomService.GetSymptoms(_configModel.Token, _configModel.language);
            ViewBag.AvailableSymptoms = symList;

            var enumValues = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.EnumValues = enumValues;

            var yearList = Enumerable.Range(DateTime.Now.Year - 100, 100);
            ViewBag.YearList = yearList;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Form(PersonVM person)
        {
            var symList = await _symtomService.GetSymptoms(_configModel.Token, _configModel.language);
            var seletedSymptoms = symList.Where(sypmtom => person.Symptoms.Contains(sypmtom.Id)).ToList();

            List<Symptoms> mappedSymptoms = seletedSymptoms.Select(symptoms => new Symptoms
            {
                Id = symptoms.Id,
                Name = symptoms.Name,
            }).ToList();

            foreach (var sym in mappedSymptoms)
            {
                var doesSymptomExist = await _healthDbContext.Symptoms.AnyAsync(x => x.Id == sym.Id);
                if (!doesSymptomExist)
                {
                    var newSym = new Symptoms
                    {
                        Id = sym.Id,
                        Name = sym.Name,
                    };

                    await _healthDbContext.Symptoms.AddAsync(newSym);
                }
            }

            await _healthDbContext.SaveChangesAsync();

            var personvm = new Person
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                YearOfBirth = person.YearOfBirth,
                Gender = person.Gender,
            };

            personvm.PersonSymptoms = mappedSymptoms.Select(x => new PersonSymptoms
            {
                SymptomId = x.Id,
            }).ToList();

            await _healthDbContext.Persons.AddAsync(personvm);
            await _healthDbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Diagnosis), new { personvm.Id });
        }

        public async Task<IActionResult> Diagnosis(int id)
        {
            var person = await _healthDbContext.Persons.FirstOrDefaultAsync(x => x.Id == id);
            var selectedSymptomsId = await _healthDbContext.PersonSymptoms.Where(x => x.PersonId == id).Select(x => x.SymptomId).ToArrayAsync();

            var diagnosis = await _symtomService.GetDiagnosis(_configModel.Token,
                                                              _configModel.language,
                                                              selectedSymptomsId,
                                                              person.Gender,
                                                              person.YearOfBirth);
            if (diagnosis == null)
            {
                string errormessage = "Sorry, we couldn't retrieve the diagnosis at the moment.";
                return RedirectToAction("ErrorView", new { errormessage });
            }

            var specialisation = diagnosis.Specialisation.Select(specialisation => new IssuesSpecialisation
            {
                SpecialisationId = specialisation.Id
            }).ToList();

            var doesIssueExist = await _healthDbContext.Issues.AnyAsync(x => x.Id == diagnosis.Issue.Id);
            var doesPersonIssueExist = await _healthDbContext.PersonIssues.AnyAsync(x => x.PersonId == id && x.IssueId == diagnosis.Issue.Id);

            if (!doesPersonIssueExist)
            {
                if (doesIssueExist)
                {
                    var newPersonIssue = new PersonIssue
                    {
                        PersonId = person.Id,
                        IssueId = diagnosis.Issue.Id,
                    };

                    await _healthDbContext.PersonIssues.AddAsync(newPersonIssue);
                }
                else
                {
                    var issue = new Issue
                    {
                        Id = diagnosis.Issue.Id,
                        Name = diagnosis.Issue.Name,
                        Icd = diagnosis.Issue.Icd,
                        IcdName = diagnosis.Issue.IcdName,
                        Accuracy = diagnosis.Issue.Accuracy,
                        ProfName = diagnosis.Issue.ProfName,
                        IssuesSpecialisations = specialisation,
                        Ranking = diagnosis.Issue.Ranking,
                    };

                    var newPersonIssue = new PersonIssue
                    {
                        PersonId = person.Id,
                        Issue = issue,
                    };

                    await _healthDbContext.PersonIssues.AddAsync(newPersonIssue);
                }
                await _healthDbContext.SaveChangesAsync();
            }

            var specialiationIds = diagnosis.Specialisation.Select(x => x.Id).ToArray();

            var doctors = _healthDbContext.Doctors.Include(s => s.Specialisation).Where(x => specialiationIds.Contains(x.SpecialisationId)).ToList();
            ViewBag.Doctors = doctors;
            ViewBag.PersonId = id;
            return View(diagnosis);
        }

        public async Task<IActionResult> BookAppointment(int doctorId, int personId)
        {
            var doctors = await _healthDbContext.Doctors.Include(s => s.Specialisation).FirstOrDefaultAsync(x => x.Id == doctorId);
            var person = await _healthDbContext.Persons.Include(i => i.PersonIssues).FirstOrDefaultAsync(p => p.Id == personId);
            if (doctors == null || person == null)
            {
                string errormessage = "Sorry, we can book appointment at the moment.";
                return RedirectToAction("ErrorView", new { errormessage });
            }
            ViewBag.SelectedDoctor = doctors;
            ViewBag.SelectedPerson = person;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BookAppointment(DoctorPatientVM appointmentModel)
        {
            try
            {
                var appointment = new DoctorPatient
                {
                    AppointmentDate = appointmentModel.AppointmentDate,
                    DoctorId = appointmentModel.DoctorId,
                    PatientId = appointmentModel.PersonId
                };

                await _healthDbContext.DoctorPatients.AddAsync(appointment);
                await _healthDbContext.SaveChangesAsync();

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message });
            }
        }

        public async Task<IActionResult> IssuesInfo(int id)
        {
            var issueInfo = await _symtomService.GetIssuesInfo(_configModel.Token, _configModel.language, id);
            if (issueInfo == null)
            {
                string errormessage = "Sorry, we couldn't retrieve the issues at the moment.";
                return RedirectToAction("ErrorView", new { errormessage });
            }
            return View(issueInfo);
        }

        public ActionResult CreateDoctor()
        {
            var spec = _healthDbContext.Specialisation.ToList();
            ViewBag.Specilisation = spec;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDoctor(DoctorVm doctor)
        {
            var spec = _healthDbContext.Specialisation.ToList();
            var selectedspec = spec.FirstOrDefault(d => doctor.specialisation == d.Id);

            var newDoc = new Doctor
            {
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                SpecialisationId = selectedspec.Id,
            };

            await _healthDbContext.Doctors.AddAsync(newDoc);
            await _healthDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(ListOfDoctors));
        }

        public ActionResult ListOfDoctors()
        {
            var doctors = _healthDbContext.Doctors.Include(b => b.Specialisation).ToList();
            return View(doctors);
        }

        public ActionResult DoctorPatient(int doctorId)
        {
            var doctorPatients = _healthDbContext.DoctorPatients.Include(dp => dp.Doctor)
                .Include(dp => dp.Person)
                .Where(dp => dp.DoctorId == doctorId)
                .ToList();

            return View(doctorPatients);
        }

        public ActionResult PersonIssues(int personId)
        {
            var personIssues = _healthDbContext.PersonIssues.Include(P => P.Person)
                .Include(i => i.Issue)
                .Where(pi => pi.PersonId == personId)
                .ToList();

            return View(personIssues);
        }

        public ActionResult ErrorView(string errormessage)
        {
            ViewBag.ErrorMessage = errormessage;
            return View("ErrorView");
        }

        public async Task<IActionResult> Persons()
        {
            var person = await _healthDbContext.Persons.ToListAsync();
            return View(person);
        }
    }
}