using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "E-mail is a required data to login.")]
        [EmailAddress(ErrorMessage = "Invalid E-mail format.")]
        [StringLength(100, ErrorMessage = "E-mail max length is {1} .")]
        public string Email { get; set; }
    }
}
