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
    public partial class UserType : Form
    {
        public UserType()
        {
            InitializeComponent();
        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_login().Show();
        }

        private void ButtonCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_login c =new Customer_login();
            c.Show();

        }

        private void Button1Employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Employee_Login().Show();


        }

        private void ButtonDeliveryman_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deliveryman_Login K = new Deliveryman_Login();
            K.Show();
        }
    }
}
