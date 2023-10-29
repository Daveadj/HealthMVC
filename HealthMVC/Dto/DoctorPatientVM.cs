namespace HealthMVC.Dto
{
    public class DoctorPatientVM
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }

        public int DoctorId { get; set; }
        public int PersonId { get; set; }
    }
}