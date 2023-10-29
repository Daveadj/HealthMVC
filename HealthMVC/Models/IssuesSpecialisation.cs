using System.ComponentModel.DataAnnotations.Schema;

namespace HealthMVC.Models
{
    public class IssuesSpecialisation
    {
        public int Id { get; set; }

        [ForeignKey(nameof(IssueId))]
        public Issue Issue { get; set; }

        public int IssueId { get; set; }

        [ForeignKey(nameof(SpecialisationId))]
        public Specialisation Specialisation { get; set; }

        public int SpecialisationId { get; set; }
    }
}