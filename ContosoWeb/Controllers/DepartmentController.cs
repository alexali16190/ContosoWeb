using Contoso.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Model;
using System.Net;
using Contoso.Model.Models;
using ContosoWeb.DTO;

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
        [HttpGet]
        //public ActionResult Update()
        //{
        //    departmentService.GetDepartmentById();
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Update(Department department)
        //{
        //    departmentService.UpdateDepartment(department);
        //    return View();
        //}

        public JsonResult Index1()
        {
            var departments = departmentService.GetAllDepartments();
            List<DepartmentDTO> dTOs = new List<DepartmentDTO>();
            foreach (var department in departments)
            {
                dTOs.Add(new DepartmentDTO { Id = department.Id, Budget = department.Budget, Name = department.Name });
            }
            return Json(departmentService.GetAllDepartments(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Create1()
        {
            return View();
        }
        
       

        

    }
}