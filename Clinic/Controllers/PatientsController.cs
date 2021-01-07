using Clinic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.Controllers
{
  public class PatientsController : Controller
  {
    private readonly ClinicContext _db;
    public PatientsController(ClinicContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Patient> patientList = _db.Patients.ToList();
      return View(patientList);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Patient patient)
    {
      _db.Patients.Add(patient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisPatient = _db.Patients
        .Include (patient => patient.Doctors)
        .ThenInclude(join => join.Doctor)
        .FirstOrDefault(patient => patient.PatientId ==id);
      return View(thisPatient);
    }

    public ActionResult Edit (int id)
    {
      var thisPatient = _db.Patients.FirstOrDefault(patient => 
    }


  }
}