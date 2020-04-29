using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_management.Controllers;
using Restaurant_management.Models;


namespace Restaurant_management.Views
{
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void ButtonAdduser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer a=  new AddCustomer();
            a.Show();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteCustomer d=  new DeleteCustomer();
            d.Show();

        }

        private void ButtonChangepass_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPasswordChange p=  new AdminPasswordChange();
            p.Show();
        }

        private void ButtonViewFood_Click(object sender, EventArgs e)
        {
            var Categories = CategoryController.GetAllCategories();
            var Foods = FoodController.GetallFood();
            this.Hide();
            OrderFood o= new OrderFood(Categories,Foods);
            o.Show();
        }

        private void ButtonAddFood_Click(object sender, EventArgs e)
        {
            var Categories = CategoryController.GetAllCategories();
            var Foods = FoodController.GetallFood();
            this.Hide();
            AddFood f= new AddFood(Categories, Foods);
            f.Show();
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAddemployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee Em = new AddEmployee();
            Em.Show();

        }

        private void ButtonDeletedeliveryman_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteDeliveryman D = new DeleteDeliveryman();
            D.Show();
        }

        private void ButtonDeleteemployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteEmployee De = new DeleteEmployee();
            De.Show();
        }

        private void ButtonaddDeliveryman_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDeleviryman d = new AddDeleviryman();
            d.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
           UserType v = new UserType();
            v.Show();
        }
    }
}
