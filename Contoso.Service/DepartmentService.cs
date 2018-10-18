using Contoso.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data.Repositories;
using Contoso.Data;

namespace Contoso.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;
        public DepartmentService()
        {
            departmentRepository = new DepartmentRepository(new ContosoDbContext());
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return departmentRepository.GetAll();
        }

        public Department GetDepartmentById(int Id)
        {
            return departmentRepository.GetById(Id);
        }
    }

    public interface IDepartmentService
    {
        IEnumerable<Department> GetAllDepartments();

        Department GetDepartmentById(int Id);
    }
}
