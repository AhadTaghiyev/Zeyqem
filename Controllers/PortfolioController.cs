using Microsoft.AspNetCore.Mvc;

namespace ArshaApp.Controllers
{
    public class PortfolioController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
