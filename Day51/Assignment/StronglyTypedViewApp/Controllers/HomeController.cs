using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewApp.Model;

namespace StronglyTypedViewApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Maya", City = "Ernakulam" },
                new Customer { Id = 2, Name = "Minu", City = "Trivandrum" },
                new Customer { Id = 3, Name = "Ammu", City = "Kottayam" }
            };

            return View(customers);
        }
    }
}

