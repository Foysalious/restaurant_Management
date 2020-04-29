using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Restaurant_management.Models
{
    public class Employees
    {
        SqlConnection conn;
        public Employees()
        {
            conn = new SqlConnection("Server=FOYSAL\\SQLEXPRESS;Database=test;Integrated Security=True;");
        }
        public void AddEmployees(Employee Employee)
        {

            conn.Open();
            string query = "INSERT INTO Employees (Name,Password,Phone,Username,Address,Email,Gander,DOB) VALUES('" + Employee.Name + "','" + Employee.Password + "','" + Employee.Phone + "','" + Employee.Username + "','" + Employee.Address + "','" + Employee.Email + "','" + Employee.Gander + "','"+Employee.DOB+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }
        public void DeleteEmployees(Employee Employee)
        {

            conn.Open();
            string query = "DELETE FROM Employees WHERE  Name =('" + Employee.Name + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }
        public Employee AuthenticateUser(string Username, string Password)
        {
            conn.Open();
            Employee u = null;
            string query = "SELECT * FROM Employees WHERE Username='" + Username + "' and Password='" + Password + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                u = new Employee();
                u.Name = reader.GetString(reader.GetOrdinal("Name"));
                u.Username = reader.GetString(reader.GetOrdinal("Username"));
                u.Password = reader.GetString(reader.GetOrdinal("Password"));
                u.E_id = reader.GetInt32(reader.GetOrdinal("E_id"));
            }
            conn.Close();
            return u;

        }
        public void ChangePassword(Employee Employee)
        {

            conn.Open();
            string query = "Update Employees SET  Password =('" + Employee.Password + "') WHERE Email=('" + Employee.Email + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }
    }
}

