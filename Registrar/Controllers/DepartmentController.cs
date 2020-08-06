using Microsoft.AspNetCore.Mvc;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Registrar.Controllers
{
  public class DepartmentController : Controller
  {
    private readonly RegistrarContext _db; 
    public DepartmentController(RegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Department> model = _db.Departments.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Department department)
    {
      _db.Departments.Add(department);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisDepartment = _db.Departments
        .Include(department => department.Courses)
        .Include(department => department.Students)
          .ThenInclude(join => join.Student)
        .FirstOrDefault(department => department.DepartmentId == id);
      return View(thisDepartment);
    }
  }
}