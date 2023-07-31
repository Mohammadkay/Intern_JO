using System.ComponentModel.DataAnnotations;

namespace GraduationProject.Models.ViewModels
{
    public class CoRegisterViewModel
    {
        [Required(ErrorMessage = "Please enter Company Name!")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Please enter some Company Info!")]
        public string CompanyInfo { get; set; }

        [Required(ErrorMessage = "Please enter company location!")]
        public string CompanyLocation { get; set; }

        [Required(ErrorMessage = "Please enter your email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please create a password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
