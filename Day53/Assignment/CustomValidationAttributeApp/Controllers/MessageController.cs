using CustomValidationAttributeApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace CustomValidationAttributeApp.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Create()
        {
            return View(new MessageAttributeModel());
        }

        [HttpPost]
        public IActionResult Create(MessageAttributeModel messageFormViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(messageFormViewModel);
            }

            return Content("Message is valid!");
        }
    }
}
