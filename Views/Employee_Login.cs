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
    public partial class Employee_Login : Form
    {
        public Employee_Login()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var result = EmployeeController.AuthenticateUser(textBoxUname.Text, textBoxPass.Text);

            if (result == true)
            {
                MessageBox.Show("Success", "Alert");
                this.Hide();
                

                Employee_Panel o = new Employee_Panel();
                o.Show();
            }
            else
            {
                MessageBox.Show("Failed", "Alert");
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateEmployeePass po= new UpdateEmployeePass();
            po.Show();
        }

        private void Employee_Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserType v = new UserType();
            v.Show();
        }
    }
    }

