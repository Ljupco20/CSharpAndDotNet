using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstMvc.Data;
using MyFirstMvc.Models;
using MyFirstMvc.Models.Entities;
using System.Data.Common;
using System.Drawing;

namespace MyFirstMvc.Controllers
{
    public class PeopleController : Controller
    {
        private FirstContext dbCon;
        public PeopleController(FirstContext dbCon)
        {
            this.dbCon = dbCon;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowPeople()
        {
 
            IEnumerable<Person> listOfPeople = dbCon.People;
            return View(listOfPeople);
        }
        [HttpGet]
        public IActionResult CreatePerson()
        {
            return View(new Person());
        }
        [HttpPost]
        public IActionResult CreatePerson(Person person)
        {
            dbCon.People.Add(person);
            dbCon.SaveChanges();

            return RedirectToAction(nameof(ShowPeople));
        }
    }
}
















