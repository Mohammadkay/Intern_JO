using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IStudentRepository Student { get; }
        public IStudentEmailsRepository StudentEmails { get; }
        public ICompanyRepository Company { get;  }
        public ICategoryRepository Category { get; }
        public ITrainingRepository Training { get; }
        public IApplicationRepository Application { get; }
        public IUniSupervisorRepository UniSupervisor { get; }
        public IUniversityRepository University { get; }
        public ICReportRepository Report { get; }
        int Complete();
    }
    
}
