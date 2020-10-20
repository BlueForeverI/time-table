using System.Linq;
using TimeTable.Data.Models;

namespace TimeTable.Services
{
    public class ProjectMonthService : BaseService<ProjectMonth>
    {
        public ProjectMonth GetByDateAndProject(decimal projectId, int month, int year)
        {
            return _context.ProjectMonths
                .Where(pm => pm.Month == month 
                    && pm.Year == year 
                    && pm.ProjectId == projectId
                    && pm.Status == "O")
                .FirstOrDefault();
        }
    }
}
