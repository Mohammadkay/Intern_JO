using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StudentEmail
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool isCreated { get; set; }
        public int UniversityId { get; set; }
        public University University { get; set; }
    }
}
