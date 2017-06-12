using StudentLeaf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentLeaf.Controllers.API
{
    public class StudentController : ApiController
    {
        private ApplicationDbContext _context;

        public StudentController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/students
        public IEnumerable<Student> GetStudents()
        {
            return _context.Student.ToList();
        }
        public IEnumerable<ActiveLesson> GetLessons()
        {
            return _context.ActiveLessons.ToList();
        }
    }
}
