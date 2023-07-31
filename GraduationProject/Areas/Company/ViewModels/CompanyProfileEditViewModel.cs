using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace GraduationProject.Areas.Company.ViewModels
{
    public class CompanyProfileEditViewModel
    {
        public string CompanyName { get; set; }
        [EmailAddress]
        public string CompanyEmail { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyInfo { get; set; }
        public string Image { get; set; }
    }
}
