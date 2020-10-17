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
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            _allEmployees = _employeeService.GetAll();
            dataGridEmployees.DataSource = _allEmployees;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            var allProjects = _projectService.GetAll();
            dataGridProjects.DataSource = allProjects;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (new AddEmployee().ShowDialog() == DialogResult.OK)
            {
                _allEmployees = _employeeService.GetAll();
                dataGridEmployees.DataSource = _allEmployees;
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (new AddProject().ShowDialog() == DialogResult.OK)
            {
                dataGridProjects.DataSource = _projectService.GetAll();
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
    }
}
