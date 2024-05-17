using System.ComponentModel.DataAnnotations;

namespace SemIdentity.Models
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool Rememberme { get; set; }
    }
}
