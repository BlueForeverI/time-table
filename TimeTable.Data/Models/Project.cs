using System;
using System.Collections.Generic;

namespace TimeTable.Data.Models
{
    public partial class Project
    {
        public Project()
        {
            ProjectHours = new HashSet<ProjectHours>();
            ProjectMonths = new HashSet<ProjectMonth>();
        }

        public decimal ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public decimal? MaxHours { get; set; }

        public virtual ICollection<ProjectHours> ProjectHours { get; set; }
        public virtual ICollection<ProjectMonth> ProjectMonths { get; set; }

        public string FullStatus
        {
            get
            {
                return Status == "O" ? "Неприключен" : "Приключен";
            }
        }
    }
}
