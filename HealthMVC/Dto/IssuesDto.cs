namespace HealthMVC.Dto
{
    public class IssuesDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Accuracy { get; set; }

        public string Icd { get; set; }

        public string IcdName { get; set; }

        public string ProfName { get; set; }

        public int Ranking { get; set; }
    }
}