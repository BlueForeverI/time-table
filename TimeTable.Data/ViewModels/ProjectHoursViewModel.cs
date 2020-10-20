using System;

namespace TimeTable.Data.ViewModels
{
    public class ProjectHoursViewModel
    {
        public decimal EmployeeId { get; set; }
        public decimal ProjectId { get; set; }
        public DateTime Date { get; set; }
        public string Project { get; set; }
        public string Task { get; set; }
        public decimal Hours { get; set; }
    }
}
