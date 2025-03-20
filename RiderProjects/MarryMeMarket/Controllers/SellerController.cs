using Microsoft.AspNetCore.Mvc;
using MarryMeMarket.Data;
using MarryMeMarket.Models;

namespace MarryMeMarket.Controllers
{
    public class SellerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SellerController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Sell() => View("~/Views/Home/sell.cshtml");

        [HttpPost]
        public IActionResult Sell(Seller seller)
        {
            if (ModelState.IsValid)
            {
                _context.Sellers.Add(seller);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View("~/Views/Home/Sell.cshtml", seller);
        }
    }
}