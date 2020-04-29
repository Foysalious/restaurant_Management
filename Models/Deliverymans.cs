using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurant_management.Models
{
    public class Deliverymans
    {
        SqlConnection conn;
        public Deliverymans()
        {
            conn = new SqlConnection("Server=FOYSAL\\SQLEXPRESS;Database=test;Integrated Security=True;");
        }
        public void AddDeliverymans(Deliveryman Deliveryman)
        {

            conn.Open();
            string query = "INSERT INTO Deliverymans (Name,Password,Phone,Username,Address,Email,Gander,DOB) VALUES('" + Deliveryman.Name + "','" + Deliveryman.Password + "','" + Deliveryman.Phone + "','" + Deliveryman.Username + "','" + Deliveryman.Address + "','" + Deliveryman.Email + "','" + Deliveryman.Gander + "','" + Deliveryman.DOB + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }
        public void DeleteDeliverymans(Deliveryman Deliveryman)
        {

            conn.Open();
            string query = "DELETE FROM Deliverymans WHERE  Name =('" + Deliveryman.Name + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }
        public Deliveryman AuthenticateUser(string Username, string Password)
        {
            conn.Open();
            Deliveryman u = null;
            string query = "SELECT * FROM Deliverymans WHERE Username='" + Username + "' and Password='" + Password + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                u = new Deliveryman();
                u.Name = reader.GetString(reader.GetOrdinal("Name"));
                u.Username = reader.GetString(reader.GetOrdinal("Username"));
                u.Password = reader.GetString(reader.GetOrdinal("Password"));
                u.D_id = reader.GetInt32(reader.GetOrdinal("D_id"));
            }
            conn.Close();
            return u;

        }
        public void ChangePassword(Deliveryman Deliveryman)
        {

            conn.Open();
            string query = "Update Deliverymans SET  Password =('" + Deliveryman.Password + "') WHERE Email=('" + Deliveryman.Email + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }

    }
}
