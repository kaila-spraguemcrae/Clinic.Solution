using Microsoft.EntityFrameworkCore;

namespace Clinic.Models{
  public class ClinicContext : DbContext{
    public DbSet<Doctor> Doctors {get; set;}
    public DbSet<Patient> Patients {get; set;}
    public DbSet<DoctorPatient> DoctorPatient {get;set;}
    public ClinicContext(DbContextOptions options) : base(options) { }
  }
}