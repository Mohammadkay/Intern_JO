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
    public class CompanyRepository : GenericRepository<Company> , ICompanyRepository
    {
        public CompanyRepository(AppDbContext _db) : base (_db)
        {
            
        }

        public Company getByAccId(string id)
        {
            return db.Companies.Where(c=>c.AccountId == id).FirstOrDefault();
        }

        public IEnumerable<Company> GetWithAcc()
        {
            return db.Companies.Include(c => c.Account).ToList();
        }

        public List<Company> Search(string term)
        {
            var result = db.Companies.Where(c=>c.CompanyName.Contains(term)|| c.CompanyInfo.Contains(term) || c.CompanyLocation.Contains(term)).ToList();
            return result;
        }
    }
}
