using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System;

namespace Clinic.Models
{
  public class Patient
  {
    public Patient()
    {
      this.Doctors = new HashSet<DoctorPatient>();
    }
    public int PatientId { get; set; }
    public string PatientName { get; set; }
    [DisplayName("Add AppointmentDate")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{yyyy-MM-dd}")]
    public DateTime AppointmentDate { get; set; }
    public ICollection<DoctorPatient> Doctors {get;}
  }
}