using HealthAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthAPI.Data
{public class HealthContext : DbContext {
    public HealthContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<Ailment>().Property(p => p.Name).HasMaxLength(40);
        builder.Entity<Medication>().Property(p => p.Name).HasMaxLength(40);
        builder.Entity<Patient>().Property(p => p.Name).HasMaxLength(40);

        builder.Entity<Ailment>().ToTable("Ailment");
        builder.Entity<Medication>().ToTable("Medication");
        builder.Entity<Patient>().ToTable("Patient");
    }

    public DbSet<Ailment> Ailments { get; set; }
    public DbSet<Medication> Medications { get; set; }
    public DbSet<Patient> Patients { get; set; }
}

}