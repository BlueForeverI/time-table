using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTable.Data.Models;

namespace TimeTable.Services
{
    public class ProjectHoursService : BaseService<ProjectHours>
    {
        public void UpdateHours(decimal employeeId, decimal projectId, DateTime date, decimal hours, string task)
        {
            var existing = _context.ProjectHours
                .Where(ph => ph.EmployeeId == employeeId && ph.ProjectId == projectId && ph.TaskDate == date)
                .First();
            existing.Hours = hours;
            existing.Task = task;
            _context.Update(existing);
            _context.SaveChanges();
        }

        public ProjectHours FindByProjectEmployeeAndDate(decimal projectId, decimal employeeId, DateTime date)
        {
            return _context.ProjectHours
                .Where(ph => ph.EmployeeId == employeeId && ph.ProjectId == projectId && ph.TaskDate == date)
                .FirstOrDefault();
        }

        public void DeleteByProjectEmployeeAndDate(decimal projectId, decimal employeeId, DateTime date)
        {
            var existing = _context.ProjectHours
                .Where(ph => ph.EmployeeId == employeeId && ph.ProjectId == projectId && ph.TaskDate == date)
                .FirstOrDefault();
            _context.ProjectHours.Remove(existing);
            _context.SaveChanges();
        }
    }
}
