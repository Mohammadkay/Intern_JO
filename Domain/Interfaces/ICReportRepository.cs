using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICReportRepository: IGenericRepository<CReport>
    {
        CReport getByStudentId(int studentId);

        bool isExists(int studentId);
    }
}
