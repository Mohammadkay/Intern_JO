using Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace GraduationProject.Areas.University.ViewModels
{
    public class AllStudentsViewModel
    {
        public IEnumerable<Student> Active { get; set; }

        public IEnumerable<Student> NonActive { get; set; }
    }
}
