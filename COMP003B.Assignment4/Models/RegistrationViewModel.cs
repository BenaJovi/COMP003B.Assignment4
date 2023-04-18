using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public string Age { get; set; }

    }
}
