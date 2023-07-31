using Domain.Entities;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GraduationProject.Areas.Company.ViewModels
{
    public class AddPostViewModel
    {
        [Display(Name = "Training Title")]

        public string TrainingTitle { get; set; }
        [Display(Name = "Training Details")]

        public string TrainingDetails { get; set; }
        [Display(Name = "Training Location")]

        public string TrainingLocation { get; set; }
        [Display(Name = "Starting Date")]

        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]

        public DateTime EndDate { get; set; }
        [Display(Name = "Category")]

        public int CategoryId { get; set; }
    }
}
