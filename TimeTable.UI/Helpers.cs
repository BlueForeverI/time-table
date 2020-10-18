using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TimeTable.UI
{
    class Helpers
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
