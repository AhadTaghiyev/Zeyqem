using Microsoft.AspNetCore.Mvc;

namespace ArshaApp.Controllers
{
    public class AboutController : Controller
    {
        public async Task <IActionResult> Index()
        {
            return View();
        }
    }
}
