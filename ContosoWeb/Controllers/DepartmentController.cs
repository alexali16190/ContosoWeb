using Contoso.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Model;
using System.Net;
using Contoso.Model.Models;

namespace ContosoWeb.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly IDepartmentService departmentService;
        public DepartmentController()
        {
            departmentService = new DepartmentService();
        }
        public ActionResult Index()
        {
            var departments = departmentService.GetAllDepartments();
            return View(departments);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department department)
        {
            departmentService.CreateDepartment(department);
            return View();
           
        }
        
       

        

    }
}