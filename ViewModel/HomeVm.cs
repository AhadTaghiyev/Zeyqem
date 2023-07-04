using ArshaApp.Models;

namespace ArshaApp.ViewModel
{
    public class HomeVm
    {
        public IEnumerable<Info> Infos { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public Setting? Setting { get; set; }
        
    }
}
