using ArshaApp.Context;
using ArshaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ArshaApp.Services
{
    public class SettingService
    {
        private readonly ArshaAppDbContext _context;
        public SettingService( ArshaAppDbContext context)
        {
            _context = context;
        }
        public async Task<Setting?> Get()
        {
            Setting? setting = await _context.Settings.FirstOrDefaultAsync();
            return setting;
        }
    }
}
