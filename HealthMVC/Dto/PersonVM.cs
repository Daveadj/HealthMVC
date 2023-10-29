namespace HealthMVC.Dto
{
    public class PersonVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int YearOfBirth { get; set; }
        public string Gender { get; set; }
        public List<int> Symptoms { get; set; }
    }

    public enum Gender
    {
        male,
        female,
    }
}