using System.ComponentModel.DataAnnotations;

namespace HealthMVC.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Display(Name = "Date of Birth")]
        public int YearOfBirth { get; set; }

        public String Gender { get; set; }
        public List<DoctorPatient> AssignedDoctors { get; set; }
        public ICollection<PersonIssue> PersonIssues { get; set; }
        public ICollection<PersonSymptoms> PersonSymptoms { get; set; }
    }
}