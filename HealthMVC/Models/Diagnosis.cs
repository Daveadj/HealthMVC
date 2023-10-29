using HealthMVC.Dto;

namespace HealthMVC.Models
{
    public class Diagnosis
    {
        public IssuesDto Issue { get; set; }

        public List<SpecialisationDto> Specialisation { get; set; }
    }
}