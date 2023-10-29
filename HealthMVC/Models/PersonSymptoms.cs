using System.ComponentModel.DataAnnotations.Schema;

namespace HealthMVC.Models
{
    public class PersonSymptoms
    {
        public int Id { get; set; }

        [ForeignKey(nameof(SymptomId))]
        public Symptoms Symptom { get; set; }

        public int SymptomId { get; set; }

        [ForeignKey(nameof(PersonId))]
        public Person Person { get; set; }

        public int PersonId { get; set; }
    }
}