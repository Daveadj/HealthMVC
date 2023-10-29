namespace HealthMVC.Dto
{
    public class PersonVm2
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public int bodyLocationId { get; set; }
        public List<int> Symptoms { get; set; }
    }
}