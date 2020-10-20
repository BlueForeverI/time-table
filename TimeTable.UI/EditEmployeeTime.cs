using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TimeTable.Data.Models;
using TimeTable.Data.ViewModels;
using TimeTable.Services;

namespace TimeTable.UI
{
    public partial class EditEmployeeTime : Form
    {
        private ProjectService _projectService;
        private ProjectMonthService _projectMonthService;
        private ProjectHoursService _projectHoursService;

        private List<Project> _openProjects;
        private decimal _employeeId;
        private decimal _projectId;
        private DateTime _taskDate;

        public EditEmployeeTime(ProjectHoursViewModel data)
        {
            InitializeComponent();
            _projectService = new ProjectService();
            _projectMonthService = new ProjectMonthService();
            _projectHoursService = new ProjectHoursService();

            _employeeId = data.EmployeeId;
            _projectId = data.ProjectId;
            _taskDate = data.Date;
            txtTask.Text = data.Task;
            npHours.Value = data.Hours;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _projectHoursService.UpdateHours(_employeeId, _projectId, _taskDate, npHours.Value, txtTask.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
