using System.ComponentModel.DataAnnotations;

namespace GraduationProject.Models.ViewModels
{
    public class EditProfileViewModel
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        [Display(Name = "Name")]

        public string StudentName { get; set; }
        [Required]
        [Display(Name ="Email")]
        public string StudentEmail { get; set; }
        [Required]
        public double GPA { get; set; }
        [Required]
        public string Skills { get; set; }
        [Required]
        public string Experience { get; set; }
        [Required]
        public string Projects { get; set; }
        [Required]
        public string Address { get; set; }
        public string Image { get; set; }
    }
}
