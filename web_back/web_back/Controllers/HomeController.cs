using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using web_back.DAL;
using web_back.Models;

namespace web_back.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;

        public HomeController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = context.Sliders.ToList();
            return View(sliders);
        }
    }
}
