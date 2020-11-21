using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TimeTable.Data.Models;
using TimeTable.Data.ViewModels;
using TimeTable.Services;
using TimeTable.ViewModels;

namespace TimeTable.UI
{
    public partial class ViewEditEmployee : Form
    {
        private Employee _employee;
        private EmployeeService _employeeService;
        private List<EmployeeProjectTimeViewModel> _projectHours;
        private List<EmployeeMonthTimeViewModel> _employeeMonthHours;

        public ViewEditEmployee(Employee employee, bool readOnly = false)
        {
            InitializeComponent();
            cmbPosition.Items.AddRange(new string[] { "Стажант", "Служител", "Мениджър" });
            _employeeService = new EmployeeService();

            _employee = employee;
            txtEgn.Text = employee.Egn;
            txtName.Text = employee.Name;
            txtSurname.Text = employee.Surname;
            txtFamilyName.Text = employee.Lastname;
            cmbPosition.Text = employee.Position;
            dpHireDate.Value = (DateTime) employee.HireDate;

            _projectHours = _employeeService.GetEmployeeProjectHours(employee.EmployeeId);
            dataGridProjectTime.DataSource = _projectHours;
            dataGridProjectTime.AutoGenerateColumns = false;

            _employeeMonthHours = _employeeService.GetEmployeeMonthHours(employee.EmployeeId);
            dataGridEmployeeMonth.DataSource = _employeeMonthHours;
            dataGridEmployeeMonth.AutoGenerateColumns = false;

            if (readOnly)
            {
                txtEgn.Enabled = false;
                txtFamilyName.Enabled = false;
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                cmbPosition.Enabled = false;
                dpHireDate.Enabled = false;
                btnSave.Enabled = false;
                this.Text = "Преглед на служител";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateEmployee())
            {
                _employee.Egn = txtEgn.Text;
                _employee.Name = txtName.Text;
                _employee.Surname = txtSurname.Text;
                _employee.Lastname = txtFamilyName.Text;
                _employee.Position = cmbPosition.Text;
                _employee.HireDate = dpHireDate.Value;
                _employeeService.Update(_employee);
                DialogResult = DialogResult.OK;
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
    }
}
