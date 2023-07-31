using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        int getCvPercent(int studentId);

        Student getStudentByAccountId(string AccId);

        Student getStudentWithTraining(int studentId);
        Student getWithUni(int id);
        int TraineeCount(int UniId);

        int NotTraineeCount(int UniId);
        public int TraineeCountByCo(int Id);
        IEnumerable<Student> GetStudentsByUni(int UniId);
        IEnumerable<Student> GetNotTrainee(int UniId);
        IEnumerable<Student> GetTraineeStudents(int UniId);
        IEnumerable<Student> GetNotActiveStudents(int UniId);
        IEnumerable<Student> GetTraineeByCo(int CompanyId);
    }
    
}
