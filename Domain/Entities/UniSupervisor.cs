using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UniSupervisor
    {
        public int UniSupervisorId { get; set; }
        public string AccountId { get; set; }
        public Account Account { get; set; }
        public int UniversityId { get; set; }
        public University University { get; set; }
    }
}
