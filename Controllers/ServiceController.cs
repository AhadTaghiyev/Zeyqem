using ArshaApp.Context;
using ArshaApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ArshaApp.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ArshaAppDbContext _context;

        public ServiceController(ArshaAppDbContext context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index()
        {
            IEnumerable<Service> services=await _context.
                Services.Where(x=>!x.IsDeleted).ToListAsync();
            return View(services);
        }
        public async Task<IActionResult> Create()
        {
            
            Service service = new Service
            {
                CreatedDate = DateTime.Now,
                Description =345,
                Icon = "<i class=\"bx bxl-dribbble\"></i>",
                Link= "https://www.youtube.com/watch?v=yei-6oSKIdQ"
            };
            Service service2 = new Service
            {
                CreatedDate = DateTime.Now,
                Description = 1234,
                Icon = "<i class=\"bx bx-file\"></i>",
                Link= "https://www.youtube.com/watch?v=yei-6oSKIdQ"
            };
            Service service3 = new Service
            {
                CreatedDate = DateTime.Now,
                Description = 567,
                Icon = "<i class=\"bx bx-tachometer\"></i>",
                Link = "https://www.youtube.com/watch?v=yei-6oSKIdQ"
            };
            Service service4 = new Service
            {
                CreatedDate = DateTime.Now,
                Description = 987,
                Icon = "<i class=\"bx bx-layer\"></i>",
                Link = "https://www.youtube.com/watch?v=yei-6oSKIdQ"
            };
            await _context.AddAsync(service);
            await _context.AddAsync(service2);
            await _context.AddAsync(service3);
            await _context.AddAsync(service4);
            await _context.SaveChangesAsync();
            return Json("ok");
        }
    }
}
