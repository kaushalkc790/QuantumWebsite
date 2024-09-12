using System.ComponentModel.DataAnnotations;

namespace QuantumWebsite.Models.ViewModels
{
    public class ContactFormViewModel
    {

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        public long Number { get; set; } 

        public string Message { get; set; }
    }
}
