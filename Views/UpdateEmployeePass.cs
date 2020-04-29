using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_management.Controllers;
namespace Restaurant_management.Views
{
    public partial class UpdateEmployeePass : Form
    {
        public UpdateEmployeePass()
        {
            InitializeComponent();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            EmployeeController.ChanagePassword(textBoxEmail.Text, textBoxPass.Text);
            string message = "Do you want to confirm this program..?";
            string title = "Alert";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();

                this.Hide();
                Employee_Login v = new Employee_Login();
                v.Show();
            }
            else
            {
                // Do something  
            }
        }

        private void UpdateEmployeePass_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Employee_Login v = new Employee_Login();
            v.Show();
        }
    }
}
