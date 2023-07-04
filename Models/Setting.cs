using System.ComponentModel.DataAnnotations;

namespace ArshaApp.Models
{
    public class Setting:BaseModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string AboutText { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public int StaffCount { get; set; }
    }
}
