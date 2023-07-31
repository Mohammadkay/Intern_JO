using DataAccess.EFCore.Repositories;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        
        private AppDbContext db;
        public UnitOfWork(AppDbContext _db)
        {
            db = _db;
            Student = new StudentRepository(db);
            StudentEmails = new StudentEmailsRepository(db);
            Company = new CompanyRepository(db);
            Category = new CategoryRepository(db);
            Training = new TrainingRepository(db);
            Application = new ApplicationRepository(db);
            UniSupervisor = new UniSupervisorRepository(db);
            University = new UniversityRepository(db);
            Report = new CReportRepository(db);
        }

        public IStudentRepository Student { get; private set; }

        public IStudentEmailsRepository StudentEmails { get; private set; }

        public ICompanyRepository Company {get; private set; }

        public ICategoryRepository Category { get; private set; }

        public ITrainingRepository Training { get; private set; }
        public IApplicationRepository Application { get; private set; }

        public IUniSupervisorRepository UniSupervisor { get; private set; }

        public IUniversityRepository University { get; private set; }

        public ICReportRepository Report { get; private set; }

        public int Complete()
        {
            return db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
