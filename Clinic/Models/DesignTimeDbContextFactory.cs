using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Clinic.Models{
  public class ClinicContextFactory : IDesignTimeDbContextFactory<ClinicContext>
  {
    ClinicContext IDesignTimeDbContextFactory<ClinicContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();
      
      var builder = new DbContextOptionsBuilder<ClinicContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new ClinicContext(builder.Options);
    }
  }
}