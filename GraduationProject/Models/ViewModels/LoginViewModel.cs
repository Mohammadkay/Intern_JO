using System.ComponentModel.DataAnnotations;

namespace GraduationProject.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Please enter your Email!")]
        [EmailAddress]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Please enter your password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
