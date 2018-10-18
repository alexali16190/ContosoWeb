using Contoso.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data.Repositories
{
    public class InstructorRepository : Repository<Instructor>, IInstructorRepository
    {
        public InstructorRepository(ContosoDbContext db) : base(db)
        {
        }
    }

    public interface IInstructorRepository : IRepository<Instructor>
    {

    }
}
