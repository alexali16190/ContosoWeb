using Contoso.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Contoso.Service;

namespace Contoso.API.Controllers
{
    [RoutePrefix("api/Department")]
    public class DepartmentController : ApiController
    {
        private readonly IDepartmentService departmentService;
        public DepartmentController()
        {
            departmentService = new DepartmentService();
        }
        [HttpGet]
        [Route("")]
        public IEnumerable<Department> GetAllDepartments()
        {
            return departmentService.GetAllDepartments();
        }
    }
}
