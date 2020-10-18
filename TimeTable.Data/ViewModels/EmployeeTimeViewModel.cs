using System;

namespace TimeTable.ViewModels
{
    public class EmployeeTimeViewModel
    {
        public decimal EmployeeId { get; set; }
        public decimal ProjectId { get; set; }
        public decimal Hours { get; set; }
        public string Task { get; set; }
        public DateTime Date { get; set; }
    }
}
