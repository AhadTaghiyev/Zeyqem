
using ArshaApp.Context;
using ArshaApp.Models;
using ArshaApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ArshaApp.Controllers
{
    public class HomeController : Controller
    {
       private readonly ArshaAppDbContext _context;
        public HomeController(ArshaAppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVm homeVm=new HomeVm();

            homeVm.Infos =await _context.Infos.Where(x=>!x.IsDeleted)
                .ToListAsync();
            homeVm.Setting =await _context.Settings.FirstOrDefaultAsync();
            homeVm.Services = await _context.Services.Where(x=>!x.IsDeleted).ToListAsync();
            return View(homeVm);
        }
        public async Task<IActionResult> Create()
        {
            Info info = new Info
            {
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Link = "https://www.youtube.com/watch?v=FkNcQ5EUB5c",
                Title = "Yenə qazamat yenə türmə",
                Image = "hero-img.png"
            };
           await _context.AddAsync(info);
           await _context.SaveChangesAsync();
            return Json("ok");
        }
        public async Task<IActionResult> CreateSetting()
        {
            var setting = new Setting
            {
                
                Email = "Zeyqam@bk.ru",
                PhoneNumber = "+9940506453635",
                Adress = "Baki,Yasamal",
                AboutText = "Yaxşısı azadə həyat ay brat",
                StaffCount = 4,
                CreatedDate=DateTime.UtcNow.AddHours(4)
            };
            await _context.AddAsync(setting);   
            await _context.SaveChangesAsync();
            return Json("ok");
        }

        
        
    }
}