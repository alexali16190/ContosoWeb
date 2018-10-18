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
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository roleRepository;
        public RoleService()
        {

            roleRepository = new RoleRepository(new ContosoDbContext());
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return roleRepository.GetAll();
        }

        public Role GetRoleById(int Id)
        {
            return roleRepository.GetById(Id);
        }
    }

    public interface IRoleService
    {
        IEnumerable<Role> GetAllRoles();

        Role GetRoleById(int Id);
    }
}
