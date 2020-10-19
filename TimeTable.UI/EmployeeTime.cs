using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TimeTable.Data.Models;
using TimeTable.Data.ViewModels;
using TimeTable.Services;

namespace TimeTable.UI
{
    public partial class EmployeeTime : Form
    {
        private EmployeeService _employeeService;
        private ProjectService _projectService;
        private List<ProjectHoursViewModel> _employeeHours;
        private List<Project> _openProjects;

        public EmployeeTime(decimal employeeId)
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            _projectService = new ProjectService();
            dataGridEmployeeHours.AutoGenerateColumns = false;

            _employeeHours = _employeeService.GetEmployeeHours(employeeId);
            _openProjects = _projectService.GetAll().Where(prj => prj.ProjectStatus == "O").ToList();
            cmbProject.DataSource = _openProjects;
            cmbProject.DisplayMember = "ProjectName";
            dataGridEmployeeHours.DataSource = _employeeHours;
        }

        private void dataGridEmployeeHours_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // edit here
        }

        private void btnAddTime_Click(object sender, System.EventArgs e)
        {
            // add here
        }
    }
}
