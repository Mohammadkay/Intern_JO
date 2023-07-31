using Domain.Entities;
using System.Collections.Generic;

namespace GraduationProject.Models.ViewModels
{
    public class SearchResultViewModel
    {
        public List<Training> Trainings { get; set; }

        public List<Company> companies { get; set; }
    }
}