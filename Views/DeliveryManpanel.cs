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
    public partial class DeliveryManpanel : Form
    {
        public DeliveryManpanel(ArrayList Purchases)
        {
            InitializeComponent();
            dataGridOrderFood.DataSource = Purchases;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridOrderFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridOrderFood.CurrentRow.Selected = true;
                string idFromDataGrid = dataGridOrderFood.Rows[e.RowIndex].Cells["F_Name"].FormattedValue.ToString();




            }

        }

        private void EditUser(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rowchanage(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
        }

        private void SelectionChange(object sender, EventArgs e)
        {
            try
            {
                var a = dataGridOrderFood.SelectedRows[0].Index.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {

            Deliverystatuscontroller.ADDDeliveryStatus(textBoxOrderno.Text, textBoxDstatus.Text);

           
        }

        private void TextBoxDstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserType v = new UserType();
            v.Show();
        }

        private void DataGridOrderFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridOrderFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridOrderFood.CurrentRow.Selected = true;
                textBoxOrderno.Text = dataGridOrderFood.Rows[e.RowIndex].Cells["Order_no"].FormattedValue.ToString();
                
            }

        }
    }
}
