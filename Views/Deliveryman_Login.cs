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
    public partial class Deliveryman_Login : Form
    {
        public Deliveryman_Login()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var result = DeliverymansController.AuthenticateUser(textBoxUname.Text, textBoxPass.Text);
            if (result == true)
            {
                MessageBox.Show("Success", "Alert");
                this.Hide();
                var Purchases = PurchaseController.GetAllOrder();

                DeliveryManpanel l = new DeliveryManpanel(Purchases);
                l.Show();
            }
            else
            {
                MessageBox.Show("Failed", "Alert");
            }

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            this.Hide();

            UpdateDeliveryPass D = new UpdateDeliveryPass();
            D.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserType v = new UserType();
            v.Show();
        }
    }
}
