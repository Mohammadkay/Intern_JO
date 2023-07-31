using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IStudentEmailsRepository : IGenericRepository<StudentEmail>
    {
        bool isExists(string email);
        StudentEmail GetStudentEmail(string email);
        void CreateTick(string email);

        IEnumerable<StudentEmail> GetStudentEmails(int UniId);
        public void RemoveStudentEmail(StudentEmail email);
        public void RemoveStudentEmail(string email);
        void AddStudentEmails(List<String> emails, int UniId);
    }
}
