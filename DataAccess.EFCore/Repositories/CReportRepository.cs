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
    public class CReportRepository: GenericRepository<CReport>, ICReportRepository
    {
        public CReportRepository(AppDbContext _db): base(_db)
        {

        }

        public CReport getByStudentId(int studentId)
        {
            CReport report = db.cReports.Include(c=>c.student).ThenInclude(s=>s.Training).ThenInclude(s=>s.Company).Include(a=>a.student.University).Where(c=>c.StudentId == studentId).SingleOrDefault();
            return report;
        }

        public bool isExists(int studentId)
        {
            if(db.cReports.Where(c => c.StudentId == studentId).Any())
            {
                return true;
            }
            return false;
        }
    }
}
