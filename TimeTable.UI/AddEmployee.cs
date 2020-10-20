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
                employee.Egn = txtEgn.Text;
                employee.Name = txtName.Text;
                employee.Surname = txtSurname.Text;
                employee.Lastname = txtFamilyName.Text;
                employee.Position = cmbPosition.Text;
                employee.HireDate = dpHireDate.Value;
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
                Helpers.ShowError("Полето ЕГН е задължително");
                result = false;
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                Helpers.ShowError("Полето Име е задължително");
                result = false;
            }
            else if (string.IsNullOrEmpty(txtSurname.Text))
            {
                Helpers.ShowError("Полето Презиме е задължително");
                result = false;
            }
            else if (string.IsNullOrEmpty(txtFamilyName.Text))
            {
                Helpers.ShowError("Полето Фамилия е задължително");
                result = false;
            }
            else if (txtEgn.Text.Length > 10)
            {
                Helpers.ShowError("Полето ЕГН трябва да е с максимално 10 символа");
                result = false;
            }

            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
