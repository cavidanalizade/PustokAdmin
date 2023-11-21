using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.DAL;
using Pustok.ViewModels;
using System.Diagnostics;

namespace Pustok.Controllers
{
    public class HomeController : Controller
    {

        AppDBC _context;

        public HomeController(AppDBC context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            HomeVM homeVM = new HomeVM
            {
                Sliders=_context.sliders.ToList(),
                Books=_context.books
                .Include(b=>b.Author)
                .Include(b=>b.BookImages).ToList(),

            };
            return View(homeVM);
        }


    }
}