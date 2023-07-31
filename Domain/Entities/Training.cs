using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Entities
{
    public class Training
    {
        [Display(Name = "ID")]
        public int TrainingId { get; set; }
        [Display(Name = "Training Title")]
        public string TrainingTitle { get; set; }
        [Display(Name = "Training Details")]
        public string TrainingDetails { get; set; }
        [Display(Name = "Training Location")]
        public string TrainingLocation { get; set; }
        public bool isAvailable { get; set; }
        [Display(Name = "Starting Date")]

        public DateTime StartDate { get; set; }
        [Display(Name = "Starting Date")]

        public DateTime EndDate { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        [Display(Name = "Category")]

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}
