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
    public class InstructorService : IInstructorService
    {
        private readonly IInstructorRepository instructorRepository;
        public InstructorService()
        {
            
            instructorRepository = new InstructorRepository(new ContosoDbContext());
        }

        public IEnumerable<Instructor> GetAllInstructors()
        {
            return instructorRepository.GetAll();
        }

        public Instructor GetInstructorById(int Id)
        {
            return instructorRepository.GetById(Id);
        }
    }

    public interface IInstructorService
    {
        IEnumerable<Instructor> GetAllInstructors();

        Instructor GetInstructorById(int Id);
    }
}
