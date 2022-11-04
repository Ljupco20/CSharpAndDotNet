using Microsoft.AspNetCore.Mvc;
using MyFirstMvc.Models;

namespace MyFirstMvc.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowPeople()
        {
            List<PersonViewModel> listOfPeople = new List<PersonViewModel>();

            PersonViewModel firstPerson = new PersonViewModel();
            firstPerson.FirstName = "Ljupco";
            firstPerson.LastName = "Trajanovski";
            listOfPeople.Add(firstPerson);

            PersonViewModel secondPerson = new PersonViewModel();
            secondPerson.FirstName = "Harry";
            secondPerson.LastName = "Kane";
            listOfPeople.Add(secondPerson);

            PersonViewModel thirdPerson = new PersonViewModel();
            thirdPerson.FirstName = "Calum";
            thirdPerson.LastName = "Wilson";
            listOfPeople.Add(thirdPerson);

            return View(listOfPeople);
        }
    }
}
