using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentLeaf.Models;

namespace StudentLeaf.Controllers
{
    public class InstructorController : Controller
    {
        private ApplicationDbContext _context;

        public InstructorController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Instructor
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            var instructors = _context.Instructor.ToList();
            return Json(instructors, JsonRequestBehavior.AllowGet);
        }
    }
}