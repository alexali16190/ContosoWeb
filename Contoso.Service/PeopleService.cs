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
        public void AddPeople(People people)
        {
            peopleRepository.Add(people);
        }
        public void UpdatePeople(People people)
        {
            peopleRepository.Update(people);
        }
    }

    public interface IPeopleService
    {
        IEnumerable<People> GetAllPeople();

        People GetPeopleById(int Id);
        void AddPeople(People people);
        void UpdatePeople(People people);
    }
}
