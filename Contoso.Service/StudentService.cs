using Contoso.Data;
using Contoso.Data.Repositories;
using Contoso.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;
        public StudentService()
        {

            studentRepository = new StudentRepository(new ContosoDbContext());
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return studentRepository.GetAll();
        }

        public Student GetStudentById(int Id)
        {
            return studentRepository.GetById(Id);
        }
    }

    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();

        Student GetStudentById(int Id);
    }
}
