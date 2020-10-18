using System.Collections.Generic;
using System.Linq;
using TimeTable.Data.Models;

namespace TimeTable.Services
{
    public class ProjectService : BaseService<Project>
    {
        public List<ProjectMonths> GetProjectMonths(decimal projectId)
        {
            return _context.ProjectMonths.Where(pm => pm.ProjectId == projectId).ToList();
        }
    }
}
