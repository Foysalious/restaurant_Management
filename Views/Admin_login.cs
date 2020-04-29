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
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var result = LoginController.AuthenticateUser(textBoxUsername.Text, textBoxPassword.Text);
            if (result == true)
            {
                MessageBox.Show("Success", "Alert");
                this.Hide();
                new Admin_Panel().Show();

            }
            else
            {
                MessageBox.Show("Failed", "Alert");
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            UserType v = new UserType();
            v.Show();
        }
    }
}
