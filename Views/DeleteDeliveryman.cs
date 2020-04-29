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
    public partial class DeleteDeliveryman : Form
    {
        public DeleteDeliveryman()
        {
            InitializeComponent();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeliverymansController.DeleteDeliverymans(textBoxdelDeliveryman.Text);
            Admin_Panel v = new Admin_Panel();
            v.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Admin_Panel v = new Admin_Panel();
            v.Show();
        }
    }
}
