using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext _db) : base(_db)
        {

        }

        public int getCvPercent(int studentId)
        {
            Student student = db.Students.Find(studentId);
            int counter = 0;
            if (student.Skills != null)
                counter++;
            if (student.Experience != null)
                counter++;
            if (student.Projects != null)
                counter++;
            if (student.Address != null)
                counter++;
            return counter;
        }

        public IEnumerable<Student> GetNotActiveStudents(int UniId)
        {
            return db.Students.Include(s=>s.Training).ThenInclude(t=>t.Company).Where(s => s.isActive == false);
        }

        public IEnumerable<Student> GetNotTrainee(int UniId)
        {
            return db.Students.Include(s => s.Training).Include(s => s.University).Where(s => s.UniversityId == UniId && s.isTrainee == false && s.isActive == true);
        }

        public Student getStudentByAccountId(string AccId)
        {
            return db.Students.Where(s => s.AccountId == AccId).FirstOrDefault();
        }

        public IEnumerable<Student> GetStudentsByUni(int UniId)
        {
            return db.Students.Include(s => s.Training).ThenInclude(t=>t.Company).Include(s => s.University).Where(s => s.UniversityId == UniId && s.isActive == true);
        }

        public Student getStudentWithTraining(int studentId)
        {
            return db.Students.Include(s=>s.University).Include(s => s.Training).ThenInclude(t => t.Company).Where(s => s.StudentId == studentId).FirstOrDefault();
        }

        public IEnumerable<Student> GetTraineeByCo(int CompanyId)
        {
            return db.Students.Include(s=>s.University).Include(s=>s.Training).Where(s=>s.isTrainee == true && s.Training.CompanyId ==  CompanyId);
        }

        public IEnumerable<Student> GetTraineeStudents(int UniId)
        {
            return db.Students.Include(s => s.Training).ThenInclude(t => t.Company).Where(s => s.isTrainee == true && s.UniversityId == UniId && s.isActive == true);
        }

        public Student getWithUni(int id)
        {
            return db.Students.Include(s=>s.University).Where(s=>s.StudentId == id).FirstOrDefault();
        }

        public int NotTraineeCount(int UniId)
        {
            return db.Students.Where(s => s.isTrainee == false && s.UniversityId == UniId).Count();
        }

        public int TraineeCount(int UniId)
        {
            return db.Students.Where(s => s.isTrainee == true && s.UniversityId == UniId).Count();
        }

        public int TraineeCountByCo(int Id)
        {
            return db.Students.Where(s=>s.isTrainee == true && s.Training.CompanyId == Id).Count();
        }
    }
}
