using System.ComponentModel.DataAnnotations;

namespace Blog_Application.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
