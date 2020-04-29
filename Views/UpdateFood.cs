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
    public partial class UpdateFood : Form
    {
        public UpdateFood()
        {
            InitializeComponent();
        }

        private void ButtonCon_Click(object sender, EventArgs e)
        {

            FoodController.UpdateFood(textBoxname.Text, textBoxPrice.Text,textBoxAv.Text);
            string message = "Do you want to confirm this program..?";
            string title = "Alert";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();

                Employee_Panel v = new Employee_Panel();
                v.Show();
            }
            else
            {
                
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Employee_Panel v = new Employee_Panel();
            v.Show();
        }
    }
}
