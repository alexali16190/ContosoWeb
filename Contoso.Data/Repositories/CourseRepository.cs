using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
using Contoso.Model.Models;

namespace Contoso.Data.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(ContosoDbContext db) : base(db)
        {
        }
    }

    public interface ICourseRepository : IRepository<Course>
    {

    }
}
