using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TestAspNet.Models;

namespace TestAspNet.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Godd Morning" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(QuestResponse questResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(questResponse);
                return View("Thanks", questResponse);
            }

            return View();
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(el => el.WillAttend == true));
        }
    }
}
