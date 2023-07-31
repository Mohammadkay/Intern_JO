using Domain.Entities;
using System.Collections.Generic;

namespace GraduationProject.Models.ViewModels
{
    public class CompanyProfileViewModel
    {
        public Company company { get; set; }

        public List<Training> trainings { get; set; }
    }
}
