using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IApplicationRepository : IGenericRepository<Application>
    {
        IEnumerable<Application> GetApplicationsByCompanyId(int companyId);
        public IEnumerable<Application> GetByStudentId(int id);

        public bool isExists(Application application);
        public Application GetApplicationById(int trainingId, int studentId);

        public int CountByCo(int id);

    }
}
