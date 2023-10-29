using Microsoft.EntityFrameworkCore;

namespace HealthMVC.Models
{
    public class HealthDbContext : DbContext
    {
        public HealthDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Symptoms> Symptoms { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Specialisation> Specialisation { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<IssuesSpecialisation> IssuesSpecialisations { get; set; }

        public DbSet<DoctorPatient> DoctorPatients { get; set; }
        public DbSet<PersonSymptoms> PersonSymptoms { get; set; }
        public DbSet<PersonIssue> PersonIssues { get; set; }
    }
}