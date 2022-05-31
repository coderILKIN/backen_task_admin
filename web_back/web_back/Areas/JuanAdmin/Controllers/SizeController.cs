using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using web_back.DAL;
using web_back.Models;

namespace web_back.Areas.JuanAdmin.Controllers
{
    [Area("JuanAdmin")]
    public class SizeController : Controller
    {
        private readonly AppDbContext context;

        public SizeController(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Size> sizes = await context.Sizes.ToListAsync();
            return View(sizes);
        }
    }
}
