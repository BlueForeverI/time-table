using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TimeTable.Data.Models;
using TimeTable.Data.ViewModels;
using TimeTable.ViewModels;

namespace TimeTable.Services
{
    public class EmployeeService : BaseService<Employee>
    {
        public List<EmployeeProjectTimeViewModel> GetEmployeeProjectHours(decimal employeeId)
        {
            return _context.ProjectHours
                .Where(ph => ph.EmployeeId == employeeId)
                .Include(ph => ph.Project)
                .GroupBy(ph => ph.Project.ProjectName)
                .Select(group => new EmployeeProjectTimeViewModel()
                {
                    ProjectName = group.Key,
                    Hours = group.Sum(ph => ph.ProjectHours1)
                })
                .ToList();
        }

        public List<EmployeeMonthTimeViewModel> GetEmployeeMonthHours(decimal employeeId)
        {
            return _context.ProjectHours
                .Where(ph => ph.EmployeeId == employeeId)
                .Include(ph => ph.ProjectMonth)
                .GroupBy(ph => new { ph.ProjectMonth.ProjectMonth, ph.ProjectMonth.ProjectYear })
                .Select(group => new EmployeeMonthTimeViewModel()
                {
                    ProjectMonth = group.Key.ProjectMonth,
                    ProjectYear = group.Key.ProjectYear,
                    Hours = group.Sum(ph => ph.ProjectHours1)
                })
                .ToList();
        }

        public List<ProjectHoursViewModel> GetEmployeeHours(decimal employeeId)
        {
            return _context.ProjectHours
                .Where(ph => ph.EmployeeId == employeeId)
                .Include(ph => ph.Project)
                .Select(ph => new ProjectHoursViewModel()
                {
                    EmployeeId = employeeId,
                    ProjectId = ph.ProjectId,
                    Date = ph.ProjectTaskdate,
                    Project = ph.Project.ProjectName,
                    Task = ph.ProjectTask,
                    Hours = ph.ProjectHours1
                })
                .ToList();
        }
    }
}
