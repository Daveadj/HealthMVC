using System.ComponentModel.DataAnnotations.Schema;

namespace HealthMVC.Models
{
    public class PersonIssue
    {
        public int Id { get; set; }

        [ForeignKey(nameof(IssueId))]
        public Issue Issue { get; set; }

        public int IssueId { get; set; }

        [ForeignKey(nameof(PersonId))]
        public Person Person { get; set; }

        public int PersonId { get; set; }
    }
}