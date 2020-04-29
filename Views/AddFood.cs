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
    public partial class AddFood : Form
    {
        public AddFood(ArrayList Categories, ArrayList Foods)
        {
            InitializeComponent();
            comboBoxCategory.DataSource = Categories;
            comboBoxCategory.DisplayMember = "Category_name";
            comboBoxCategory.ValueMember = "Category_id";
        }

        

        private void Add_Click(object sender, EventArgs e)
        {
            var c = (Category)comboBoxCategory.SelectedItem;
            FoodController.AddFoods(textBoxFname.Text, textBoxFprice.Text, textBoxFava.Text, c.Category_id);

            MessageBox.Show("add", "Alert");
            
        }

        private void TextBoxFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserType v = new UserType();
            v.Show();
        }
    }
}
