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
    public class UniSupervisorRepository :GenericRepository<UniSupervisor>, IUniSupervisorRepository
    {
        public UniSupervisorRepository(AppDbContext _db) : base(_db)
        {
            
        }
        public UniSupervisor GetByAccId(string accId)
        {
            return db.UniSupervisors.Include(s=>s.University).Where(s=>s.AccountId == accId).FirstOrDefault();
        }
    }
}
