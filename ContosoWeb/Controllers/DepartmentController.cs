using Contoso.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Model;
using System.Net;


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
        
        
       

        

    }
}