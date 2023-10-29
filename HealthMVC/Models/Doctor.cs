using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthMVC.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [ForeignKey(nameof(SpecialisationId))]
        public Specialisation Specialisation { get; set; }

        public int SpecialisationId { get; set; }

        public List<DoctorPatient> AssignedPatients { get; set; }
    }
}