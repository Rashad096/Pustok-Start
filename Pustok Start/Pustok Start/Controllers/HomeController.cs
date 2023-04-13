using Microsoft.AspNetCore.Mvc;
using Pustok_Start.DAL;
using Pustok_Start.Models;
using Pustok_Start.ViewModels;
using System.Diagnostics;

namespace Pustok_Start.Controllers
{
    public class HomeController : Controller
    { public readonly PustokDbContext _context;
      
        public HomeController(PustokDbContext context)
        {
            _context = context;
        }
   
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Sliders = _context.Sliders.ToList(),
            };
            return View(vm);
        }

        public IActionResult Privacy()
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