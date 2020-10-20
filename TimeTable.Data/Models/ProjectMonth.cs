using System.Collections.Generic;

namespace TimeTable.Data.Models
{
    public partial class ProjectMonth
    {
        public ProjectMonth()
        {
            ProjectHours = new HashSet<ProjectHours>();
        }

        public decimal ProjectMonthId { get; set; }
        public decimal ProjectId { get; set; }
        public decimal Year { get; set; }
        public decimal Month { get; set; }
        public string Status { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<ProjectHours> ProjectHours { get; set; }

        public string FullStatus
        {
            get
            {
                return Status == "O" ? "Неприключен" : "Приключен";
            }
        }
    }
}
