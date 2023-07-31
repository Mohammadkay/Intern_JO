using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore.Repositories
{
    public class StudentEmailsRepository : GenericRepository<StudentEmail>, IStudentEmailsRepository
    {
        public StudentEmailsRepository(AppDbContext _db) : base(_db)
        {
        }

        public void AddStudentEmails(List<string> emails, int UniId)
        {
            StudentEmail Email;
            foreach (var email in emails)
            {
                Email = new StudentEmail();
                Email.Email = email;
                Email.UniversityId = UniId;
                Email.isCreated = false;
                db.StudentEmails.Add(Email);
            }
        }

        public void RemoveStudentEmail(string email)
        {
            StudentEmail se = db.StudentEmails.Where(s=>s.Email == email).FirstOrDefault();
            db.StudentEmails.Remove(se);
        }
        public void RemoveStudentEmail(StudentEmail email)
        {
            db.StudentEmails.Remove(email);
        }
        public void CreateTick(string email)
        {
            StudentEmail se = db.StudentEmails.Where(s=>s.Email == email).FirstOrDefault();
            if (se != null)
            {
                se.isCreated = true;
            }
        }

        public StudentEmail GetStudentEmail(string email)
        {
            return db.StudentEmails.Where(s=>s.Email == email).FirstOrDefault();
        }

        public IEnumerable<StudentEmail> GetStudentEmails(int UniId)
        {
            return db.StudentEmails.Where(s => s.UniversityId == UniId);
        }

        public bool isExists(string email)
        {
            var check = db.StudentEmails.Where(e=>e.Email == email);
            if(check.Any())
            {
                return true;
            }
            return false;
        }
    }
}
