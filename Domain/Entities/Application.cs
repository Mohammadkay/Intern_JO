using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Application
    {
        public int TrainingId { get; set; }
        public Training Training { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public enum status
        {
            Pending,
            Accepted,
            Rejected
        }
        public status Status { get; set; }

    }
}
