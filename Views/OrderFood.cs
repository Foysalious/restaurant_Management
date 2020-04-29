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
using Restaurant_management.Models;
using Restaurant_management.Controllers;
namespace Restaurant_management.Views
{
    public partial class OrderFood : Form
    {
        public OrderFood(ArrayList Categories, ArrayList Foods)
        {
            InitializeComponent();

           
            dataGridViewFood.DataSource = Foods;
        }

        private void ButtonOrder(object sender, EventArgs e)
        {
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RowChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            // var c = dataGridViewFood.SelectedRows[0].Cells[2].Value;
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var a = dataGridViewFood.SelectedRows[0].Index.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewFood.AutoGenerateColumns = false;
         
        }

        private void DataGridViewFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewFood.CurrentRow.Selected = true;
                string idFromDataGrid = dataGridViewFood.Rows[e.RowIndex].Cells["Food_Name"].FormattedValue.ToString();




            }

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text) == true)
            {
                MessageBox.Show("Please Enter Name");
                tbName.Focus();

            }

            if (string.IsNullOrEmpty(textBoxAddress.Text) == true)
            {
                MessageBox.Show("Please Enter Address");
                tbName.Focus();
                textBoxAddress.Focus();
            }

            if (string.IsNullOrEmpty(textBoxPhone.Text) == true)
            {
                MessageBox.Show("Please Enter Phone");

                textBoxAddress.Focus();
            }
            if (string.IsNullOrEmpty(textBoxCusname.Text) == true)
            {
                MessageBox.Show("Please Enter Category");

                textBoxCusname.Focus();
            }
            else
            {
                PurchaseController.NewPurchases(tbName.Text, textBoxAddress.Text, textBoxPhone.Text, textBoxCusname.Text,tbPrice.Text);

                string message = "Do you want to confirm this program..?";
                string title = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;


                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    UserType f = new UserType();

                    f.Show();

                }
                else
                {
                    // Do something  
                }
            }

        }

        private void TextboxFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UserType f = new UserType();
            f.Show();
            
        }

        private void DataGridViewFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewFood.CurrentRow.Selected = true;
                tbName.Text = dataGridViewFood.Rows[e.RowIndex].Cells["Food_Name"].FormattedValue.ToString();
                tbPrice.Text = dataGridViewFood.Rows[e.RowIndex].Cells["Food_Price"].FormattedValue.ToString();
            }
        }

        private void DataGridViewFood_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
