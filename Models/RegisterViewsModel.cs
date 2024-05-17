using System.ComponentModel.DataAnnotations;

namespace SemIdentity.Models
{
    public class RegisterViewsModel
    {
        [EmailAddress]
        [Required]
        public string? Email { get; set; }
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Passoword",ErrorMessage = "as senhas não conferem")]
        public string? ConfirmPassword { get; set; }
    }
}
