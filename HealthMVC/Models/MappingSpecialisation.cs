namespace HealthMVC.Models
{
    public class MappingSpecialisation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SpecialisationId { get; set; }

        public Doctor? Doctor { get; set; }
    }
}