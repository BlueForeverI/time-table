using System;
using System.Windows.Forms;
using TimeTable.UI;

namespace TimeTable
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "admin" && this.txtPassword.Text == "admin")
            {
                var mainWindow = new Main();
                mainWindow.Show();
                this.Hide();
            }
            else
            {
                lblErrorMessage.Text = "Грешно име или парола";
                lblErrorMessage.Visible = true;
            }
        }
    }
}
