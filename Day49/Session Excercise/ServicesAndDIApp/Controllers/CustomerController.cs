using Microsoft.AspNetCore.Mvc;
using ServicesAndDIApp.Services;

namespace ServicesAndDIApp.Controllers
{
    public class CustomerController : Controller
    {
        private IRRdEmailService _rdrEmailService;
        public CustomerController(IRRdEmailService emailService)
        {
            _rdrEmailService = emailService;
        }
        public string Index()
        {

            _rdrEmailService.SendEmailAsync("admin@rrd", "contoller", "customer registration controller");
            return "<h1>Hello I am Index action of home controller</h1>";
        }
    }
}
