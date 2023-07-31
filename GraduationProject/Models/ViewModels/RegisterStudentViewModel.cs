using System.ComponentModel.DataAnnotations;

namespace GraduationProject.Models.ViewModels
{
    public class RegisterStudentViewModel
    {
        [Required(ErrorMessage ="Please enter your name!")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter your email!")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please create a password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Please confirm your password!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
