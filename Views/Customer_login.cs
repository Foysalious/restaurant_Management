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
    public partial class Customer_login : Form
    {
        public Customer_login()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer k = new AddCustomer();
            k.Show();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var result = CustomerController.AuthenticateUser(textBoxUname.Text, textBoxPass.Text);
            if (result == true)
            {
                MessageBox.Show("Success", "Alert");
                this.Hide();
                var Categories = CategoryController.GetAllCategories();
                var Foods = FoodController.GetallFood();
                
               OrderFood o = new OrderFood(Categories, Foods);
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
            UpdateCustomerpass w= new UpdateCustomerpass();
            w.Show();
        }

        private void Customer_login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserType v = new UserType();
            v.Show();
        }
    }
}
