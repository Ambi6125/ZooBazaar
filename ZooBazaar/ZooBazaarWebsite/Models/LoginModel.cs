using System.ComponentModel.DataAnnotations;

namespace SynthesisWebsite.Models
{
    public class LoginModel
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "The email is required")]
        public string Email { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Your  password is required")]
        public string Password { get; set; }
    }
}
