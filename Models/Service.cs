using System.ComponentModel.DataAnnotations;

namespace ArshaApp.Models
{
    public class Service:BaseModel
    {
        [Required]
        public int Description { get; set; }
        [Required]
        public string Icon { get; set; }

        [Required]
        public string Link { get; set; }

    }
}
