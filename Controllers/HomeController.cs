using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FinanceHub.Models;

namespace FinanceHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<Transaction> transactions = new List<Transaction>{
         new Transaction{ TransactionID = 1,UserID = 101,Type = "Income",Category = "Salary",Amount = 4000.00m,Date = new DateTime(2025, 4, 1),Description = "Monthly salary"},
         new Transaction{ TransactionID = 2,UserID = 102,Type = "Expense",Category = "Food",Amount = 200.00m,Date = new DateTime(2025, 4, 2),Description = "Groceries"},
         new Transaction{ TransactionID = 3,UserID = 101,Type = "Expense",Category = "Transport",Amount = 50.00m,Date = new DateTime(2025, 4, 3),Description = "Bus fare"},
         new Transaction{ TransactionID = 4,UserID = 103,Type = "Expense",Category = "Entertainment",Amount = 100.00m,Date = new DateTime(2025, 4, 4),Description = "Movie tickets"},
         new Transaction{ TransactionID = 5,UserID = 103,Type = "Income",Category = "Investment",Amount = 500.00m,Date = new DateTime(2025, 4, 5),Description = "Stock dividends"},
         new Transaction{ TransactionID = 6,UserID = 104,Type = "Expense",Category = "Utilities",Amount = 150.00m,Date = new DateTime(2025, 4, 6),Description = "Electricity bill"},
         };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action for the Home page
        public IActionResult Index()
        {
            return View(); // Returns the Index.cshtml view
        }

        // Action for the Charts page
        public IActionResult Charts()
        {
            return View(); // Returns the Charts.cshtml view
        }

        // Action for the About Us page
        public IActionResult About()
        {
            return View(); // Returns the About.cshtml view
        }

        // Action for Privacy page
        public IActionResult Privacy()
        {
            return View(); // Returns the Privacy.cshtml view
        }

        // Action for Get Started page
        public IActionResult GetStarted()  // <-- This is the one you just added
        {
            return View();
        }

        // Action for the Create page
        public IActionResult Create()
        {
            return View();
        }

        // Action for the Read page
        public IActionResult Read()
        {
            return View(transactions);
        }

        // Action for the Update page
        public IActionResult Update(int id)
        {
            if (id == null)
            {
                ViewBag.NeedsTransactionId = true;
                return View(); // Just ask for ID
            }
            var transaction = transactions.FirstOrDefault(t => t.TransactionID == id);

            if (transaction == null)
            {
                ViewBag.NeedsTransactionId = true;
                ViewBag.ErrorMessage = $"Transaction with ID {id} not found.";
                return View();
            }
            return View(transaction);
        }

        [HttpPost]
        public IActionResult Update(Transaction updatedTransaction)
        {
            // Simulate update
            TempData["Message"] = $"Transaction #{updatedTransaction.TransactionID} updated.";
            return RedirectToAction("Read");
        }

        // Action for the Delete page
        public IActionResult Delete(int id)
        {
            var tr = transactions.FirstOrDefault(t => t.TransactionID == id);
            if (tr != null)
            {
                transactions.Remove(tr);
                TempData["Message"] = $"Transaction #{id} deleted.";
                return RedirectToAction("Read");
            }
            else
            {
                ViewBag.ErrorMessage = $"Transaction with ID {id} not found.";
            }
            return RedirectToAction("Read"); // simulate delete
        }

        public IActionResult CrudOperations()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}