using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Restaurant_management.Controllers;
namespace Restaurant_management.Views
{
    public partial class AddEmployee : Form
    {
        string emailValStr = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            int Phonenum = textBoxPhone.Text.Length;
            int Passwordl = textBoxPass.Text.Length;

            if (radioMale.Checked)
            {
                groupBoxGander.Text = radioMale.Text;

            }
            if (radioFemale.Checked)
            {
                groupBoxGander.Text = radioFemale.Text;

            }




            if (string.IsNullOrEmpty(textBoxname.Text) == true)
            {
                MessageBox.Show("Please Enter Name");
                textBoxname.Focus();

            }
            else if (string.IsNullOrEmpty(textBoxPass.Text) == true)
            {
                MessageBox.Show("Please Enter phone number");
                textBoxPass.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxUname.Text) == true)
            {
                MessageBox.Show("Please Enter USername");
                textBoxUname.Focus();
            }

            else if (Passwordl <= 6)
            {
                MessageBox.Show("Your password should contain minimum 6 characters or numbers");

                textBoxPass.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxPhone.Text) == true)
            {
                MessageBox.Show("Please enter Phone Number");
                textBoxPhone.Focus();
            }
            else if (Phonenum != 11)
            {

                MessageBox.Show("Please enter valid phone number");
                textBoxPhone.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxEmail.Text) == true)
            {
                MessageBox.Show("Invalid email!!");
                textBoxEmail.Focus();

            }

            else if (string.IsNullOrEmpty(textBoxaddress.Text) == true)
            {
                MessageBox.Show("Please enter Address");

            }

            else if (textBoxPass.Text != textBoxConpass.Text)
            {
                MessageBox.Show("Password is not matched");
                textBoxPass.Focus();
            }

            else if (Regex.IsMatch(textBoxEmail.Text, emailValStr) == false)
            {
                MessageBox.Show("Invalid Email..!!");

                textBoxEmail.Focus();

            }
            else if (string.IsNullOrEmpty(groupBoxGander.Text) == true)
            {

                MessageBox.Show("Please select gender");
                groupBoxGander.Focus();
            }
            else
            {


                EmployeeController.AddEmployees(textBoxname.Text, textBoxUname.Text, textBoxPass.Text, textBoxEmail.Text, textBoxaddress.Text, textBoxPhone.Text, groupBoxGander.Text, dateTimePicker1.Value.ToString("dd-MM-yyyy"));

                string message = "Do you want to confirm this program..?";
                string title = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;


                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    Admin_Panel v = new Admin_Panel();
                    v.Show();
                }
                else
                {
                    // Do something  
                }
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Panel f = new Admin_Panel();

            f.Show();
        }
    }
}
