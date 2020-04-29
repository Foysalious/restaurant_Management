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

namespace Restaurant_management.Views
{
    public partial class Status : Form
    {
        public Status(ArrayList DeliveryStatus)
        {
            InitializeComponent();
            dataGridViewStatus.DataSource = DeliveryStatus;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rowchange(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            {
                if (e.StateChanged != DataGridViewElementStates.Selected) return;
            }
        }

        private void SelectionChange(object sender, EventArgs e)
        {
            try
            {
                var a = dataGridViewStatus.SelectedRows[0].Index.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Status_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Employee_Panel v = new Employee_Panel();
            v.Show();
        }
    }
}
