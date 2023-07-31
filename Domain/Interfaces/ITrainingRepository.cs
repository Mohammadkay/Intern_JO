using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ITrainingRepository : IGenericRepository<Training>
    {
        IEnumerable<Training> getByCategory(int id);
        public int GetCategoryIdByTraining(int id);
        public List<Training> Search(string term);
        public List<Training> GetByCo(int id);
        public int CountByCo(int id);
        List<Training> GetTrainingsByCompanyId(int companyId);
        public List<Training> GetAllByCo(int companyId);
    }
}
