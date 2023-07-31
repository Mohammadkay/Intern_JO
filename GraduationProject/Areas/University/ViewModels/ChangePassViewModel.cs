using System.ComponentModel.DataAnnotations;

namespace GraduationProject.Areas.University.ViewModels
{
    public class ChangePassViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        public string Current { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string New { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("New", ErrorMessage ="Your Passwords does not match")]
        public string ConfirmNew { get; set; }
    }
}
