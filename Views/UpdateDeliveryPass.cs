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
    public partial class UpdateDeliveryPass : Form
    {
        public UpdateDeliveryPass()
        {
            InitializeComponent();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            DeliverymansController.ChanagePassword(textBoxEmail.Text, textBoxPass.Text);
            string message = "Do you want to confirm this program..?";
            string title = "Alert";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Deliveryman_Login v = new Deliveryman_Login();
                v.Show();

            }
            else
            {
                // Do something  
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deliveryman_Login v = new Deliveryman_Login();
            v.Show();
        }
    }
}
