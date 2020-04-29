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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {


        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            CustomerController.DeleteCustomers(textBoxdelcustomer.Text);
            Admin_Panel f = new Admin_Panel();

            f.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Admin_Panel f = new Admin_Panel();

            f.Show();
        }
    }
}
