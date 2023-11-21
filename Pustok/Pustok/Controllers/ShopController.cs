using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.DAL;
using Pustok.ViewModels;
using System.Diagnostics;
namespace Pustok.Controllers
{
    public class ShopController : Controller
    {
        AppDBC _context;

        public ShopController(AppDBC context)
        {
            _context = context;
        }
        public IActionResult Detail(int id)
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = _context.sliders.ToList(),
                Books = _context.books
                .Include(b => b.Author)
                .Include(b => b.BookImages).ToList(),

            };

            return View(homeVM);
        }
    }
}
