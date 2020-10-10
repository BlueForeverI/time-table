using System;

namespace TimeTable.Data.Models
{
    public partial class ProjectHours
    {
        public decimal ProjectId { get; set; }
        public decimal EmployeeId { get; set; }
        public DateTime ProjectTaskdate { get; set; }
        public decimal? ProjectMonthId { get; set; }
        public string ProjectTask { get; set; }
        public decimal ProjectHours1 { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
        public virtual ProjectMonths ProjectMonth { get; set; }
    }
}
