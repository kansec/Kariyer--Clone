using System.ComponentModel.DataAnnotations;

namespace KariyerClone.Models.Dtos
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength: 15, MinimumLength = 6, ErrorMessage = "Your password is limited to 6 to 15 characters")]
        public string Password { get; set; }

    }
}
