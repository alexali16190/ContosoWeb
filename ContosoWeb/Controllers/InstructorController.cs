using Contoso.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoWeb.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorService instructorService;
        public InstructorController()
        {
            instructorService = new InstructorService();
        }
        public ActionResult Index()
        {
            var instructors = instructorService.GetAllInstructors();
            return View(instructors);
        }
    }
}