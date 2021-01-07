using Clinic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.Controllers
{
  public class DoctorsController : Controller
  {
    private readonly ClinicContext _db;
    public DoctorsController(ClinicContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Doctor> doctorList = _db.Doctors.ToList();
      return View(doctorList);
    }
    
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Doctor doctor)
    {
      _db.Doctors.Add(doctor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisDoctor = _db.Doctors
        .Include(doctor => doctor.Patients)
        .ThenInclude(join => join.Patient)
        .FirstOrDefault(doctor => doctor.DoctorId ==id);
      return View(thisDoctor);
    }

    public ActionResult Edit (int id)
    {
      var thisDoctor = _db.Doctors.FirstOrDefault(doctor =>doctor.DoctorId ==id);
      return View(thisDoctor);
    }

    [HttpPost]
    public ActionResult Edit (Doctor doctor)
    {
      _db.Entry(doctor).State = En
    }
  }
}