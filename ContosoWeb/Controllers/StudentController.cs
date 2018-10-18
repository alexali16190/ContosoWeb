using Contoso.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoWeb.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        private readonly IStudentService studentService;
        public StudentController()
        {
            studentService = new StudentService();
        }
        public ActionResult Index()
        {
            var students = studentService.GetAllStudents();
            return View(students);
        }
    }
}