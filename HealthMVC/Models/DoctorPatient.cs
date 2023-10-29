using System.ComponentModel.DataAnnotations.Schema;

namespace HealthMVC.Models
{
    public class DoctorPatient
    {
        public int Id { get; set; }

        public DateTime AppointmentDate { get; set; }

        [ForeignKey(nameof(DoctorId))]
        public Doctor Doctor { get; set; }

        public int DoctorId { get; set; }

        [ForeignKey(nameof(PatientId))]
        public Person Person { get; set; }

        public int PatientId { get; set; }
    }
}