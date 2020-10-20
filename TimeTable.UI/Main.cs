using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TimeTable.Data.Models;
using TimeTable.Services;

namespace TimeTable.UI
{
    public partial class Main : Form
    {
        private EmployeeService _employeeService;
        private ProjectService _projectService;
        private List<Employee> _allEmployees;
        private List<Project> _allProjects;

        public Main()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            _projectService = new ProjectService();
            tabPage1.Enter += tabPage1_Click;
            tabPage2.Enter += tabPage2_Click;

            dataGridEmployees.AutoGenerateColumns = false;
            dataGridProjects.AutoGenerateColumns = false;

            cmbSearchEmployeeType.Items.AddRange(new string[] { "ЕГН", "Име", "Презиме", "Фамилия", "Длъжност", "Дата на постъпване" });
            cmbSearchEmployeeType.Text = "ЕГН";

            cmbSearchProjectType.Items.AddRange(new string[] { "Име", "Начало", "Край", "Описание", "Статус" });
            cmbSearchProjectType.Text = "Име";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            ReloadEmployees();
        }

        private void ReloadEmployees()
        {
            _allEmployees = _employeeService.GetAll();
            dataGridEmployees.DataSource = _allEmployees;
            dataGridProjects.Refresh();
        }

        private void ReloadProjects()
        {

            _allProjects = _projectService.GetAll();
            dataGridProjects.DataSource = _allProjects;
            dataGridProjects.Refresh();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            ReloadProjects();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (new AddEmployee().ShowDialog() == DialogResult.OK)
            {
                ReloadEmployees();
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (new AddProject().ShowDialog() == DialogResult.OK)
            {
                ReloadProjects();
            }
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchEmployee.Text))
            {
                var query = txtSearchEmployee.Text;
                switch(cmbSearchEmployeeType.Text)
                {
                    case "ЕГН":
                        dataGridEmployees.DataSource = _allEmployees.Where(emp => emp.EmployeeEgn.Contains(query)).ToList();
                        break;
                    case "Име":
                        dataGridEmployees.DataSource = _allEmployees.Where(emp => emp.EmployeeName.Contains(query)).ToList();
                        break;
                    case "Презиме":
                        dataGridEmployees.DataSource = _allEmployees.Where(emp => emp.EmployeeSurname.Contains(query)).ToList();
                        break;
                    case "Фамилия":
                        dataGridEmployees.DataSource = _allEmployees.Where(emp => emp.EmployeeLastname.Contains(query)).ToList();
                        break;
                    case "Длъжност":
                        dataGridEmployees.DataSource = _allEmployees.Where(emp => emp.EmployeePosition.Contains(query)).ToList();
                        break;
                    case "Дата на постъпване":
                        dataGridEmployees.DataSource = _allEmployees.Where(emp => emp.EmployeeHiredate.ToString().Contains(query)).ToList();
                        break;
                }
            }
        }

        private void btnClearEmployeeSearch_Click(object sender, EventArgs e)
        {
            txtSearchEmployee.Text = "";
            dataGridEmployees.DataSource = _allEmployees;
        }

        private void dataGridEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridEmployees.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                Employee employee = _allEmployees[e.RowIndex];
                if (e.ColumnIndex == 7)
                {
                    if (new ViewEditEmployee(employee).ShowDialog() == DialogResult.OK)
                    {
                        ReloadEmployees();
                    }
                }
                else
                {
                    new EmployeeTime(employee.EmployeeId).ShowDialog();
                }
            }
        }

        private void btnClearProjectSearch_Click(object sender, EventArgs e)
        {
            txtSearchProject.Text = "";
            dataGridProjects.DataSource = _allProjects;
        }

        private void btnSearchProject_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchProjectt.Text))
            {
                var query = txtSearchProjectt.Text;
                switch (cmbSearchProjectType.Text)
                {
                    case "Име":
                        dataGridProjects.DataSource = _allProjects.Where(p => p.ProjectName.Contains(query)).ToList();
                        break;
                    case "Начало":
                        dataGridProjects.DataSource = _allProjects.Where(p => p.ProjectBegin.ToString().Contains(query)).ToList();
                        break;
                    case "Край":
                        dataGridProjects.DataSource = _allProjects.Where(p => p.ProjectEnd.ToString().Contains(query)).ToList();
                        break;
                    case "Описание":
                        dataGridProjects.DataSource = _allProjects.Where(p => p.ProjectDescription.Contains(query)).ToList();
                        break;
                    case "Статус":
                        dataGridProjects.DataSource = _allProjects.Where(p => p.FullStatus.Contains(query)).ToList();
                        break;
                }
            }
        }

        private void dataGridProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridProjects.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                Project project = _allProjects[e.RowIndex];
                if (new ViewEditProject(project).ShowDialog() == DialogResult.OK)
                {
                    ReloadProjects();
                }
            }
        }
    }
}
