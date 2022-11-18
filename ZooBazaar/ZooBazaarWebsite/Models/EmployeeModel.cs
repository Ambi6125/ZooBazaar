using System.ComponentModel.DataAnnotations;

namespace SynthesisWebsite.Models
{
    public class EmployeeModel
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "The email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Birthdate is required")]
        public string BirthDate { get; set; }
        public int id { get; set; }
        public string username { get; set; }
    }
}
