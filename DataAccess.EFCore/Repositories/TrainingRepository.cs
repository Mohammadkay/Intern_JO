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
    public class TrainingRepository : GenericRepository<Training>, ITrainingRepository
    {
        public TrainingRepository(AppDbContext _db) : base(_db)
        {
            
        }

        public int CountByCo(int id)
        {
            return db.Trainings.Where(t=>t.CompanyId == id && t.isAvailable == true).Count();
        }

        public List<Training> GetAllByCo(int companyId)
        {
            return db.Trainings.Where(t=>t.CompanyId == companyId).ToList();
        }

        public IEnumerable<Training> getByCategory(int id)
        {
            return db.Trainings.Include(t=>t.Category).Include(t=>t.Company).Where(t => t.CategoryId == id && t.isAvailable == true).ToList();
        }

        public List<Training> GetByCo(int id)
        {
            return db.Trainings.Where(t=>t.CompanyId == id && t.isAvailable == true).ToList();
        }

        public int GetCategoryIdByTraining(int id)
        {
            var training = db.Trainings.Find(id);
            return training.CategoryId;
        }


        public List<Training> GetTrainingsByCompanyId(int companyId)
        {
            return db.Trainings.Include(t => t.Category).Include(t => t.Company).Where(t => t.CompanyId == companyId && t.isAvailable == true).ToList();
        }

        public List<Training> Search(string term)
        {
            var result = db.Trainings.Include(t => t.Category).Include(t=>t.Company).Where(t=>(t.TrainingTitle.Contains(term) || t.TrainingDetails.Contains(term) || t.Company.CompanyName.Contains(term)  || t.Category.CategoryName.Contains(term)) && t.isAvailable == true).ToList();
            return result;
        }
    }
}
