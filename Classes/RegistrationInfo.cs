using System.ComponentModel.DataAnnotations;

namespace Portfolio.Classes
{
    public class RegistrationInfo
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public Role? Role { get; set; }

        [Required, RegularExpression(@"\w+\@\w+(\.\w+)+", ErrorMessage = "Email address is not valid.")]
        public string Email { get; set; } = string.Empty;

        [Required (ErrorMessage = "The password field is required.")]
        [MinLength(8)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "The confirm password field is required.")]
        [Compare(nameof(Password), ErrorMessage = "Passwords must match")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }

    public enum Role
    {
        Buyer,
        Seller
    }
}
