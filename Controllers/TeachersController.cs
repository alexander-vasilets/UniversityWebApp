using Microsoft.AspNetCore.Mvc;

using UniversityWebApp.Data;
using UniversityWebApp.Models;

namespace UniversityWebApp.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TeachersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Teachers);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Teacher t = _db.Teachers.Find(id);
            return View(t);
        }
        [HttpPost]
        public IActionResult Edit(Teacher t)
        {
            Teacher teacher = _db.Teachers.Find(t.Id);
            teacher.Name = t.Name;
            _db.SaveChanges();
            return View("Index", _db.Teachers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Teacher t)
        {
            _db.Teachers.Add(t);
            _db.SaveChanges();
            return View("Index", _db.Teachers);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Teacher teacher = _db.Teachers.Find(id);
            return View(teacher);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            //if (id != null)
            //{
                Teacher teacher = _db.Teachers.Find(id);
                _db.Teachers.Remove(teacher);
                _db.SaveChanges();
            //}
            return View("Index", _db.Teachers);
        }
    }
}
