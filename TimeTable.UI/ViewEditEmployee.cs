using System;
using System.Windows.Forms;
using TimeTable.Data.Models;
using TimeTable.Services;

namespace TimeTable.UI
{
    public partial class ViewEditEmployee : Form
    {
        private Employee _employee;
        private EmployeeService _employeeService;

        public ViewEditEmployee(Employee employee)
        {
            InitializeComponent();
            cmbPosition.Items.AddRange(new string[] { "Стажант", "Служител", "Мениджър" });
            _employeeService = new EmployeeService();

            _employee = employee;
            txtEgn.Text = employee.EmployeeEgn;
            txtName.Text = employee.EmployeeName;
            txtSurname.Text = employee.EmployeeSurname;
            txtFamilyName.Text = employee.EmployeeLastname;
            cmbPosition.Text = employee.EmployeePosition;
            dpHireDate.Value = (DateTime) employee.EmployeeHiredate;
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
                _employee.EmployeeEgn = txtEgn.Text;
                _employee.EmployeeName = txtName.Text;
                _employee.EmployeeSurname = txtSurname.Text;
                _employee.EmployeeLastname = txtFamilyName.Text;
                _employee.EmployeePosition = cmbPosition.Text;
                _employee.EmployeeHiredate = dpHireDate.Value;
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
