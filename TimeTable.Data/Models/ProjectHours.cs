using System;

namespace TimeTable.Data.Models
{
    public partial class ProjectHours
    {
        public decimal ProjectId { get; set; }
        public decimal EmployeeId { get; set; }
        public DateTime TaskDate { get; set; }
        public decimal? ProjectMonthId { get; set; }
        public string Task { get; set; }
        public decimal Hours { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
        public virtual ProjectMonth ProjectMonth { get; set; }
    }
}
