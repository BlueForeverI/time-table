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
            if (new Login().ShowDialog() == DialogResult.Yes)
            {
                InitializeComponent();
                _employeeService = new EmployeeService();
                _projectService = new ProjectService();
                tabPage1.Enter += tabPage1_Click;
                tabPage2.Enter += tabPage2_Click;

                dataGridEmployees.AutoGenerateColumns = false;
                dataGridProjects.AutoGenerateColumns = false;

                cmbEmployeeSerachPosition.Items.AddRange(new string[] { "", "Стажант", "Служител", "Мениджър" });

                cmbSearchProjectType.Items.AddRange(new string[] { "Име", "Начало", "Край", "Описание", "Статус" });
                cmbSearchProjectType.Text = "Име";
            }
            else
            {
                Close();
            }
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
            var name = txtSearchEmployeeName.Text;
            var surname = txtSearchEmployeeSurname.Text;
            var lastName = txtEmployeeSerchLastName.Text;
            var egn = txtSearchEmployeeEgn.Text;
            var position = cmbEmployeeSerachPosition.SelectedItem?.ToString();
            var hireDate = dpEmployeeSearchHireDate.Checked ? (DateTime?) dpEmployeeSearchHireDate.Value : null;

            var query = _allEmployees.AsQueryable();
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.Name.Contains(name));
            }

            if (!string.IsNullOrEmpty(surname))
            {
                query = query.Where(e => e.Surname.Contains(surname));
            }

            if (!string.IsNullOrEmpty(lastName))
            {
                query = query.Where(e => e.Lastname.Contains(lastName));
            }

            if (!string.IsNullOrEmpty(egn))
            {
                query = query.Where(e => e.Egn.Contains(egn));
            }

            if (!string.IsNullOrEmpty(position))
            {
                query = query.Where(e => e.Position.Contains(position));
            }

            if (hireDate != null)
            {
                query = query.Where(e => e.HireDate.Value.Date == hireDate.Value.Date);
            }

            dataGridEmployees.DataSource = query.ToList();
        }

        private void btnClearEmployeeSearch_Click(object sender, EventArgs e)
        {
            txtSearchEmployeeName.Text = "";
            txtSearchEmployeeSurname.Text = "";
            txtEmployeeSerchLastName.Text = "";
            txtSearchEmployeeEgn.Text = "";
            cmbEmployeeSerachPosition.SelectedItem = "";
            dpEmployeeSearchHireDate.Value = new DateTime();
            dpEmployeeSearchHireDate.Checked = false;
            dataGridEmployees.DataSource = _allEmployees;
        }

        private void dataGridEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridEmployees.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                Employee employee = _allEmployees[e.RowIndex];
                if (e.ColumnIndex == 7 || e.ColumnIndex == 8)
                {
                    if (new ViewEditEmployee(employee, e.ColumnIndex == 7).ShowDialog() == DialogResult.OK)
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
                        dataGridProjects.DataSource = _allProjects.Where(p => p.Name.Contains(query)).ToList();
                        break;
                    case "Начало":
                        dataGridProjects.DataSource = _allProjects.Where(p => p.Begin.ToString().Contains(query)).ToList();
                        break;
                    case "Край":
                        dataGridProjects.DataSource = _allProjects.Where(p => p.End.ToString().Contains(query)).ToList();
                        break;
                    case "Описание":
                        dataGridProjects.DataSource = _allProjects.Where(p => p.Description.Contains(query)).ToList();
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
                if (new ViewEditProject(project, e.ColumnIndex == 6).ShowDialog() == DialogResult.OK)
                {
                    ReloadProjects();
                }
            }
        }
    }
}
