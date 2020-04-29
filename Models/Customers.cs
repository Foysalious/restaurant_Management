using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Restaurant_management.Models
{
    public class Customers
    {
        SqlConnection conn;
        public Customers()
        {
            conn = new SqlConnection("Server=FOYSAL\\SQLEXPRESS;Database=test;Integrated Security=True;");
        }
            public void AddCustomers(Customer Customer)
            {
                
                conn.Open();
                string query = "INSERT INTO Customers (Name,Password,Phone,Username,Address,Email,Gander,DOB) VALUES('" + Customer.Name + "','" + Customer.Password + "','" + Customer.Phone + "','"+Customer.Username+"','"+Customer.Address+"','"+Customer.Email+"','"+Customer.Gander+ "','" + Customer.DOB + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();


            }
        public void DeleteCustomers(Customer Customer)
        {

            conn.Open();
            string query = "DELETE FROM Customers WHERE  Name =('"+ Customer.Name + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }
        public Customer AuthenticateUser(string Username, string Password)
        {
            conn.Open();
            Customer u = null;
            string query = "SELECT * FROM Customers WHERE Username='" + Username + "' and Password='" + Password + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                u = new Customer();
                u.Name = reader.GetString(reader.GetOrdinal("Name"));
                u.Username = reader.GetString(reader.GetOrdinal("Username"));
                u.Password = reader.GetString(reader.GetOrdinal("Password"));
                u.C_id = reader.GetInt32(reader.GetOrdinal("C_id"));
            }
            conn.Close();
            return u;

        }
        public void ChangePassword(Customer Customer)
        {

            conn.Open();
            string query = "Update Customers SET  Password =('" + Customer.Password + "') WHERE Email=('" + Customer.Email + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }


    }
}
