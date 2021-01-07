using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Clinic.Controllers{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}