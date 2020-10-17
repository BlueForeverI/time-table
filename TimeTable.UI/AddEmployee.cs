using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeTable.Data.Models;
using TimeTable.Services;

namespace TimeTable.UI
{
    public partial class AddEmployee : Form
    {
        private EmployeeService _employeeService;
        public AddEmployee()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            cmbPosition.Items.AddRange(new string[] { "Стажант", "Служител", "Мениджър" });
            cmbPosition.Text = "Служител";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateEmployee())
            {
                Employee employee = new Employee();
                employee.EmployeeEgn = txtEgn.Text;
                employee.EmployeeName = txtName.Text;
                employee.EmployeeSurname = txtSurname.Text;
                employee.EmployeeLastname = txtFamilyName.Text;
                employee.EmployeePosition = cmbPosition.Text;
                employee.EmployeeHiredate = dpHireDate.Value;
                _employeeService.Add(employee);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateEmployee()
        {
            bool result = true;
            if (string.IsNullOrEmpty(txtEgn.Text))
            {
                ShowError("Полето ЕГН е задължително");
                result = false;
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                ShowError("Полето Име е задължително");
                result = false;
            }
            else if (string.IsNullOrEmpty(txtSurname.Text))
            {
                ShowError("Полето Презиме е задължително");
                result = false;
            }
            else if (string.IsNullOrEmpty(txtFamilyName.Text))
            {
                ShowError("Полето Фамилия е задължително");
                result = false;
            }
            else if (txtEgn.Text.Length > 10)
            {
                ShowError("Полето ЕГН трябва да е с максимално 10 символа");
                result = false;
            }

            return result;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
