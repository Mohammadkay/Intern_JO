using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        [Display(Name ="Company Name")]
        public string CompanyName { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyInfo { get; set; }
        [EmailAddress]
        public string CompanyEmail { get; set; }
        public string AccountId { get; set; }
        public Account Account { get; set; }
        public ICollection<Training> Trainings { get; set; }
        public string Image { get; set; }
    }
}
