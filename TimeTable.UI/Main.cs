using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TimeTable.Services;

namespace TimeTable.UI
{
    public partial class Main : Form
    {
        private EmployeeService _employeeService;
        private ProjectService _projectService;
        public Main()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            _projectService = new ProjectService();
            tabPage1.Enter += tabPage1_Click;
            tabPage2.Enter += tabPage2_Click;

            dataGridEmployees.AutoGenerateColumns = false;
            dataGridProjects.AutoGenerateColumns = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            var allEmployees = _employeeService.GetAll();
            dataGridEmployees.DataSource = allEmployees;
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
                dataGridEmployees.DataSource = _employeeService.GetAll();
            }
        }
    }
}
