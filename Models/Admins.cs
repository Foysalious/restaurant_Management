using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurant_management.Models
{
    public class Admins
    {
        SqlConnection conn;
        public Admins()
        {

            conn = new SqlConnection("Server=FOYSAL\\SQLEXPRESS;Database=test;Integrated Security=True;");
            //conn = new SqlConnection("Server=FOYSAL\\SQLEXPRESS;Database=Restuarant_Management;User Id=sa;Password=123") ;
        }


        public Admin AuthenticateUser(string Username, string Password)
        {
            conn.Open();
            Admin u = null;
            string query = "SELECT * FROM Admins WHERE Username='" + Username + "' and Password='" + Password + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                u = new Admin();
                u.Name = reader.GetString(reader.GetOrdinal("Name"));
                u.Username = reader.GetString(reader.GetOrdinal("Username"));
                u.Password = reader.GetString(reader.GetOrdinal("Password"));
                u.A_id = reader.GetInt32(reader.GetOrdinal("A_id"));
            }
            conn.Close();
            return u;

        }


        public void ChangePassword(Admin Admin)
        {

            conn.Open();
            string query = "Update Admins SET  Password =('" + Admin.Password + "') WHERE Email=('"+Admin.Email+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }

    }
}
