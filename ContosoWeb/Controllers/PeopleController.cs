using Contoso.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoWeb.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        private readonly IPeopleService peopleService;
        public PeopleController()
        {
            peopleService = new PeopleService();
        }
        public ActionResult Index()
        {
            var people = peopleService.GetAllPeople();
            return View(people);
        }
    }
}