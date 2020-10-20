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
                ProjectMonth = pm.Month,
                ProjectYear = pm.Year,
                ProjectMonthStatus = pm.Status,
                HourSum = pm.ProjectHours.Sum(ph => ph.Hours),
                EmployeeCount = pm.ProjectHours.Select(ph => ph.EmployeeId).Distinct().Count()
            }).ToList();
        }
    }
}
