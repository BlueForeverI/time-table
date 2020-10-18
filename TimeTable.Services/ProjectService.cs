using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;
using TimeTable.Data.Models;
using TimeTable.Data.ViewModels;

namespace TimeTable.Services
{
    public class ProjectService : BaseService<Project>
    {
        public List<ProjectMonthViewModel> GetProjectMonths(decimal projectId)
        {
            var projectMonths = _context.ProjectMonths.Where(pm => pm.ProjectId == projectId).Include(pm => pm.ProjectHours);
            return projectMonths.Select(pm => new ProjectMonthViewModel()
            {
                ProjectId = pm.ProjectId,
                ProjectMonthId = pm.ProjectMonthId,
                ProjectMonth = pm.ProjectMonth,
                ProjectYear = pm.ProjectYear,
                ProjectMonthStatus = pm.ProjectMonthStatus,
                HourSum = pm.ProjectHours.Sum(ph => ph.ProjectHours1),
                EmployeeCount = pm.ProjectHours.Select(ph => ph.EmployeeId).Distinct().Count()
            }).ToList();
        }
    }
}
