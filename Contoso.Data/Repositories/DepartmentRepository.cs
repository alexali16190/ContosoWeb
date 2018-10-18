using Contoso.Model.Models;

namespace Contoso.Data.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ContosoDbContext db) : base(db)
        {
        }
    }

    public interface IDepartmentRepository : IRepository<Department>
    {

    }
}
