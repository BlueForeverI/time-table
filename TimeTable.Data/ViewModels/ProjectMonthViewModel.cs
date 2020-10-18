using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTable.Data.ViewModels
{
    public class ProjectMonthViewModel
    {
        public decimal ProjectMonthId { get; set; }
        public decimal ProjectId { get; set; }
        public decimal ProjectYear { get; set; }
        public decimal ProjectMonth { get; set; }
        public string ProjectMonthStatus { get; set; }
        public int EmployeeCount { get; set; }
        public decimal HourSum { get; set; }

        public string FullStatus
        {
            get
            {
                return ProjectMonthStatus == "O" ? "Неприключен" : "Приключен";
            }
        }
    }
}
