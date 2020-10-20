﻿using System;
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
                DialogResult = DialogResult.Yes;
                Close();
            }
            else
            {
                MessageBox.Show("Грешно потребителско име или парола", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
