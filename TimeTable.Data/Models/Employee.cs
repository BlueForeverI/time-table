using System;
using System.Collections.Generic;

namespace TimeTable.Data.Models
{
    public partial class Employee
    {
        public Employee()
        {
            ProjectHours = new HashSet<ProjectHours>();
        }

        public decimal EmployeeId { get; set; }
        public string Egn { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public string Position { get; set; }
        public DateTime? HireDate { get; set; }

        public virtual ICollection<ProjectHours> ProjectHours { get; set; }
    }
}
