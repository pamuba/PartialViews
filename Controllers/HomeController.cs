using Microsoft.AspNetCore.Mvc;
using PartialViews.Models;

namespace PartialViews.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            //ViewData["ListTitle"] = "Cities";
            //ViewData["ListItems"] = new List<string>()
            //{
            //    "Paris",
            //    "New York",
            //    "Bangalore",
            //    "Rome"
            //};
            return View();
        }
        [Route("about")]
        public IActionResult About()
        {
            return View();
        }
        [Route("programming-languages")]
        public IActionResult ProgrammingLanguages() {

            ListModel listModel = new ListModel()
            {
                ListTitle = "Programming Languages List",
                ListItems = new List<string>()
                {
                    "C#",
                    "Java",
                    "TS",
                    "Python",
                    "C++"
                }
            };

            //return new PartialViewResult() { ViewName = "_ListPartialView", ViewData = listModel };
            return PartialView("_ListPartialView", listModel);
        }
    }
}
