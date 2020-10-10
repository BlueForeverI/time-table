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
        public Main()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            tabPage1.Enter += tabPage1_Click;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            var allEmployees = _employeeService.GetAll();
            dataGridEmployees.DataSource = allEmployees;
        }
    }
}
