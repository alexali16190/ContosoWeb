using Contoso.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data.Repositories
{
    public class PeopleRepository : Repository<People>, IPeopleRepository
    {
        public PeopleRepository(ContosoDbContext db) : base(db)
        {
        }
    }

    public interface IPeopleRepository : IRepository<People>
    {

    }
}
