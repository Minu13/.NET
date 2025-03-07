using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SampleBankingApp.DTOs;
using SampleBankingApp.Services;


namespace SampleBankingApp.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {
        private readonly ITransactionService _transactionService;
        private readonly IDashboardService _dashboardService;

        public TransactionController(ITransactionService transactionService, IDashboardService dashboardService)
        {
            _transactionService = transactionService;
            _dashboardService = dashboardService;
        }

        public IActionResult Index()
        {
            var userEmail = User.Identity.Name; 
            var account = _dashboardService.GetAccountByEmail(userEmail).Result;

            if (account == null)
            {
                return RedirectToAction("Error", "Home"); 
            }

            var transactionDto = new TransactionDTO
            {
                AccountId = account.AccountId
            };

            return View(transactionDto);
        }


        [HttpPost]
        public async Task<IActionResult> ProcessTransaction(TransactionDTO transactionDto)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Invalid input. Please correct the errors.";
                return View("Index", transactionDto);
            }

            try
            {
                if (transactionDto.TransactionType == "Withdraw")
                {
                   
                    var account = await _dashboardService.GetAccountById(transactionDto.AccountId);

                    if (account == null)
                    {
                        ViewBag.Error = "Account not found.";
                        return View("Index", transactionDto);
                    }

                    if (account.Balance < transactionDto.Amount)
                    {
                        ViewBag.Error = "Insufficient balance.";
                        return View("Index", transactionDto);
                    }

                    transactionDto.Amount *= -1; 
                }

                await _transactionService.ProcessTransaction(transactionDto);
                return RedirectToAction("Index", "Dashboard");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "An error occurred: " + ex.Message;
                return View("Index", transactionDto);
            }
        }

    }
}
