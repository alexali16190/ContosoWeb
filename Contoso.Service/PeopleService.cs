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
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository peopleRepository;
        public PeopleService()
        {

            peopleRepository = new PeopleRepository(new ContosoDbContext());
        }

        public IEnumerable<People> GetAllPeople()
        {
            return peopleRepository.GetAll();
        }

        public People GetPeopleById(int Id)
        {
            return peopleRepository.GetById(Id);
        }
    }

    public interface IPeopleService
    {
        IEnumerable<People> GetAllPeople();

        People GetPeopleById(int Id);
    }
}
