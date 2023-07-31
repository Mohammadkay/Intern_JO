using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class University
    {
        public int UniversityId { get; set; }
        public string UniversityName { get; set; }
        public ICollection<Student> Students { get; set; }
        public int UniSupervisorId { get; set; }
        public UniSupervisor UniSupervisor { get; set; }
    }
}
