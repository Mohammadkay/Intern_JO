using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore.Repositories
{
    public class ApplicationRepository: GenericRepository<Application>, IApplicationRepository
    {
        public ApplicationRepository(AppDbContext _db) : base(_db)
        {
        }

        public IEnumerable<Application> GetApplicationsByCompanyId(int companyId)
        {
            return db.Applications
               .Include(a => a.Training)
               .Include(a => a.Student).ThenInclude(s=>s.University)
               .Where(a => a.Training.CompanyId == companyId && a.Status != Application.status.Rejected)
               .ToList();
        }

        public IEnumerable<Application> GetByStudentId(int id)
        {
            return db.Applications.Include(a=>a.Training).ThenInclude(t=>t.Company).Where(a => a.StudentId == id).ToList();
        }

        public bool isExists(Application application)
        {
            var result = db.Applications.Where(a=>a.TrainingId == application.TrainingId && a.StudentId == application.StudentId);
            if (result.Any())
            {
                return true;
            }
            return false;
        }
        public Application GetApplicationById(int trainingId, int studentId)
        {
            return db.Applications.Include(a=>a.Training).Where(a => a.TrainingId == trainingId && a.StudentId == studentId).FirstOrDefault();
        }

        public int CountByCo(int id)
        {
            List<Training> list = db.Trainings.Where(t=>t.CompanyId == id).ToList();
            int count = 0;
            foreach (Training training in list)
            {
                count += db.Applications.Where(a => a.TrainingId == training.TrainingId && a.Status != Application.status.Rejected).Count();
            }
            return count;
        }
    }
}
