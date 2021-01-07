using System.Collections.Generic;

namespace Clinic.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.Patients = new HashSet<Doctor>();
    }
  

  public int DoctorId { get; set; }
  public string DoctorName { get; set; }
  public string DoctorField { get; set; }

  public ICollection<DoctorPatient> Patients {get;}
  
  }
}