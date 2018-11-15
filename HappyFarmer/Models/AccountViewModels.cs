using System.ComponentModel.DataAnnotations;

namespace HappyFarmer.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "The {0} must be between {1} - {2} characters.", MinimumLength = 5)]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        
        [StringLength(50, ErrorMessage = "The {0} must be between {1} - {2} characters.", MinimumLength = 5)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [StringLength(50, ErrorMessage = "The {0} must be between {1} - {2} characters.", MinimumLength = 5)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}