using System;
using System.Collections.Generic;

namespace TimeTable.Data.Models
{
    public partial class Project
    {
        public Project()
        {
            ProjectHours = new HashSet<ProjectHours>();
            ProjectMonths = new HashSet<ProjectMonths>();
        }

        public decimal ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime ProjectBegin { get; set; }
        public DateTime ProjectEnd { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectStatus { get; set; }
        public decimal? ProjectMaxhours { get; set; }

        public virtual ICollection<ProjectHours> ProjectHours { get; set; }
        public virtual ICollection<ProjectMonths> ProjectMonths { get; set; }

        public string FullStatus
        {
            get
            {
                return ProjectStatus == "O" ? "Неприключен" : "Приключен";
            }
        }
    }
}
