using System.Linq;
using TimeTable.Data.Models;

namespace TimeTable.Services
{
    public class ProjectMonthService : BaseService<ProjectMonths>
    {
        public ProjectMonths GetByDateAndProject(decimal projectId, int month, int year)
        {
            return _context.ProjectMonths
                .Where(pm => pm.ProjectMonth == month 
                    && pm.ProjectYear == year 
                    && pm.ProjectId == projectId
                    && pm.ProjectMonthStatus == "O")
                .FirstOrDefault();
        }
    }
}
