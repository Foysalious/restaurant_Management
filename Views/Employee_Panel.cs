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
    public partial class Employee_Panel : Form
    {
        public Employee_Panel()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var Categories = CategoryController.GetAllCategories();
            var Foods = FoodController.GetallFood();
            this.Hide();
            AddFood f = new AddFood(Categories, Foods);
            f.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateFood().Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteFood().Show();


        }

        private void ButtonDeliveryStatus_Click(object sender, EventArgs e)
        {
            var DeliveryStatus = Deliverystatuscontroller.GetAllstatus();
            this.Hide();
            Status s = new Status(DeliveryStatus);
            s.Show();
            

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            UserType v = new UserType();
            v.Show();
        }
    }
}
