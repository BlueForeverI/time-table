using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTable.Data.Models;

namespace TimeTable.Services
{
    public class ProjectHoursService : BaseService<ProjectHours>
    {
        public void UpdateHours(decimal employeeId, decimal projectId, DateTime date, decimal hours)
        {
            var existing = _context.ProjectHours
                .Where(ph => ph.EmployeeId == employeeId && ph.ProjectId == projectId && ph.ProjectTaskdate == date)
                .First();
            existing.ProjectHours1 = hours;
            _context.Update(existing);
            _context.SaveChanges();
        }
    }
}
