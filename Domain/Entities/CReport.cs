using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CReport
    {
        public enum Rate
        {
            Accpetable,
            Good,
            Excellent
        }

        public int CReportId { get; set; }
        
        [Display(Name = "Total Number of training hours:")]
        public int Hours { get; set; }
        
        [Display(Name = "How do you evaluate the student's commitment to working hours?")]
        public Rate Commitment { get; set; }
        
        [Display(Name = "Has  the  ability  to  gain  valuable  practical experience  and  build  on  top  of  his/her knowledge.")]
        public Rate Experience { get; set; }
        
        [Display(Name = "A  good  team  worker;  willing  to  cooperate; accepts  ideas; desires  to  improve;  shows interest; works well with others ")]
        public Rate TeamWork { get; set; }
        
        [Display(Name = "Accomplishes  an  acceptable  amount  of  tasks with accurate and correct solutions; fast; eager; does a good job. ")]
        public Rate Tasks { get; set; }

        [Display(Name = "Has  the  ability  to  combine  theoretical  and practical knowledge in problem‐solving.")]
        public Rate ProblemSolving { get; set; }
        
        [Display(Name = "Technical Competency; possess good conceptual skills; organizational skills. ")]
        public Rate Technical { get; set; }
        
        [Display(Name = "Overall rating")]
        public Rate OverAll { get; set; }
        
        [Display(Name = "What  suggestions  do  you  have  for  the  student  that  might  increase  his/her  value  to  the organization and further his/her professional development? ")]
        public string suggestions { get; set; }

        [Display(Name = "Has the training coordinator at the university communicated with the company?")]
        public bool communicate { get; set; }
        

        [Display(Name ="Name")]
        public string SupervisorName { get; set; }
        

        [Display(Name = "Email")]
        public string SupervisorEmail { get; set; }
        

        [Display(Name ="Phone")]
        public string SupervisorPhone { get; set; }
        

        [Display(Name ="Date")]
        public DateTime dateSubmitted { get; set; }

        public int StudentId { get; set; }
        public Student student { get; set; }


    }
}
