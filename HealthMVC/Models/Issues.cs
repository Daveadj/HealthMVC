using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthMVC.Models
{
    public class Issue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Accuracy { get; set; }

        public string Icd { get; set; }

        public string IcdName { get; set; }

        public string ProfName { get; set; }

        public int Ranking { get; set; }

        public ICollection<IssuesSpecialisation> IssuesSpecialisations { get; set; }

        public ICollection<PersonIssue> PersonIssues { get; set; }
    }
}