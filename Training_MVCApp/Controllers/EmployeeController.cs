using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Training_MVCApp.Models;

namespace Training_MVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        PersonDBEntities _dbContext;

        public EmployeeController()
        {
            _dbContext = new PersonDBEntities();
        }
        public ActionResult Index()
        {
            ViewData["ViewDataMessage"] = "Hello World from ViewData!";
            ViewBag.VBMessage = "Hello World from ViewBag!";

            List<Person> PersonList = _dbContext.Person.ToList();
            ViewBag.PersonLists = PersonList;

            return View();
        }

        public ActionResult ShowEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShowEmployee(MPerson ObjMPerson)
        {
            //Person ObjPerson = new Person
            //{
            //    FirstName = ObjMPerson.FirstName
            //};
            //_dbContext.Person.Add(ObjPerson);
            //_dbContext.SaveChanges();
            return View();
        }
    }
}