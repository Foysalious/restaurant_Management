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
    public partial class AdminPasswordChange : Form
    {
        public AdminPasswordChange()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginController.ChanagePassword(textBoxAEmail.Text, textBoxPass.Text);
            string message = "Do you want to confirm this program..?";
            string title = "Alert";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Admin_Panel v = new Admin_Panel();
                v.Show();
               
            }
            else
            {
                // Do something  
            }
        }

        private void TextBoxA_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Admin_Panel f = new Admin_Panel();

            f.Show();
        }
    }
}
