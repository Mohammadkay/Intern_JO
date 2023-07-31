using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public bool isTrainee { get; set; }
        public double GPA { get; set; }
        public string Skills { get; set; }
        public string Experience { get; set; }
        public string Projects { get; set; }
        public string Address { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpierationDate { get; set; }
        public bool isActive { get; set; }
        public int? TrainingId { get; set; }
        public Training Training { get; set; }
        public ICollection<Application> Applications { get; set; }
        public string AccountId { get; set; }
        public Account Account { get; set; }
        public int? UniversityId { get; set; }
        public University University { get; set; }
        public string Image { get; set; }
    }
}
