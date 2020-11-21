using System;
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
        private ProjectMonthService _projectMonthService;
        private ProjectHoursService _projectHoursService;

        private List<ProjectHoursViewModel> _employeeHours;
        private List<Project> _openProjects;
        private decimal _employeeId;

        public EmployeeTime(decimal employeeId)
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            _projectService = new ProjectService();
            _projectMonthService = new ProjectMonthService();
            _projectHoursService = new ProjectHoursService();
            dataGridEmployeeHours.AutoGenerateColumns = false;

            _employeeId = employeeId;
            ReloadProjectHours();
            _openProjects = _projectService.GetAll().Where(prj => prj.Status == "O").ToList();
            cmbProject.DataSource = _openProjects;
            cmbProject.DisplayMember = "Name";

            var employee = _employeeService.GetById(employeeId);
            txtEmployeeName.Text = employee.Name;
            txtEmployeeSurname.Text = employee.Surname;
            txtEmployeeLastName.Text = employee.Lastname;
            txtEgn.Text = employee.Egn;
            txtPosition.Text = employee.Position;
        }

        private void ReloadProjectHours()
        {
            _employeeHours = _employeeService.GetEmployeeHours(_employeeId);
            dataGridEmployeeHours.DataSource = _employeeHours;
            dataGridEmployeeHours.Refresh();
        }

        private void dataGridEmployeeHours_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // edit here
        }

        private void btnAddTime_Click(object sender, System.EventArgs e)
        {
            DateTime taskDate = dpDate.Value;
            if (taskDate >= DateTime.Now.AddDays(1))
            {
                Helpers.ShowError("Датата на отчитане не може да е в бъдещето");
                return;
            }

            Project project = cmbProject.SelectedValue as Project;
            ProjectMonth activeMonth = _projectMonthService.GetByDateAndProject(project.ProjectId, taskDate.Month, taskDate.Year);

            if (activeMonth == null)
            {
                Helpers.ShowError("Няма активен отчетен месец за избераната дата и проект");
                return;
            }

            if (string.IsNullOrEmpty(txtTask.Text))
            {
                Helpers.ShowError("Полето Дейност е задължително");
                return;
            }

            if (_projectHoursService.FindByProjectEmployeeAndDate(project.ProjectId, _employeeId, taskDate) != null)
            {
                Helpers.ShowError("Отчетено време за този проект и дата вече съществуват");
                return;
            }

            ProjectHours timeEntry = new ProjectHours();
            timeEntry.ProjectId = project.ProjectId;
            timeEntry.EmployeeId = _employeeId;
            timeEntry.TaskDate = taskDate;
            timeEntry.ProjectMonthId = activeMonth.ProjectMonthId;
            timeEntry.Task = txtTask.Text;
            timeEntry.Hours = npHours.Value;
            _projectHoursService.Add(timeEntry);
            ReloadProjectHours();
        }

        private void dataGridEmployeeHours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridEmployeeHours.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var entry = _employeeHours[e.RowIndex];
                if (e.ColumnIndex == 5)
                {
                    if (new EditEmployeeTime(entry).ShowDialog() == DialogResult.OK)
                    {
                        ReloadProjectHours();
                    }
                }
                else
                {
                    _projectHoursService.DeleteByProjectEmployeeAndDate(entry.ProjectId, _employeeId, entry.Date);
                    ReloadProjectHours();
                }
            }
        }
    }
}
