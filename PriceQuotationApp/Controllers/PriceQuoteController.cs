using Microsoft.AspNetCore.Mvc;
using PriceQuotationApp.Models;

namespace PriceQuotationApp.Controllers
{
    public class PriceQuoteController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new PriceQuoteModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(PriceQuoteModel model)
        {
            if (ModelState.IsValid)
            {
                // If the form data is valid, return the view with the calculated model
                return View(model);
            }
            return View(model); // If not valid, redisplay the form with validation errors
        }

        // Clear action to reset the form
        public IActionResult Clear()
        {
            return RedirectToAction("Index");
        }
    }
}
