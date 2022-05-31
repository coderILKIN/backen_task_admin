using Microsoft.AspNetCore.Mvc;

namespace web_back.Areas.JuanAdmin.Controllers
{
    [Area("JuanAdmin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
