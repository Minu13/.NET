using Microsoft.AspNetCore.Mvc;

namespace ServicesAndDIApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            Console.WriteLine("controller created");

        }

        public string Index()
        {
            return "Hello am index action of home controller";
        }

        public string SayHello()
        {

            return "Hello";
        }
    }
}
