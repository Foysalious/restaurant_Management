using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Restaurant_management.Models
{
    public class Foods
    {
        SqlConnection conn;
        public Foods()
        {
            conn = new SqlConnection("Server=FOYSAL\\SQLEXPRESS;Database=test;Integrated Security=True;");

        }
        public void AddFoods(Food Food)
        {

            conn.Open();
            string query = "INSERT INTO Foods (Food_Name,Food_price,Availability,Category_id) VALUES('" + Food.Food_Name + "','" + Food.Food_Price + "','" + Food.Availability + "'," + Food.Category_id + ")";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();



        }

        public void UpdateFood(Food Food)
        {

            conn.Open();
            string query = "Update Foods SET Availability= '"+Food.Availability+"',Food_price='" + Food.Food_Price + "' WHERE Food_Name ='" + Food.Food_Name + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }

        public void DeleteFoods(Food Food)
        {

            conn.Open();
            string query = "DELETE FROM Foods WHERE Food_Name = ('" + Food.Food_Name + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();



        }
    
        public Food GetFood(string Food_Name)
        {
            Food f = new Food();
            return f;

        }

        public ArrayList GetAllFoods()
        {
            ArrayList Foods = new ArrayList();

            conn.Open();
            string query = "SELECT * FROM Foods";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Food temp = new Food()
                {

                F_id = reader.GetInt32(reader.GetOrdinal("F_id")),
                Food_Name = reader.GetString(reader.GetOrdinal("Food_Name")),
                Food_Price = reader.GetString(reader.GetOrdinal("Food_Price")),
                Availability = reader.GetString(reader.GetOrdinal("Availability")),
                Category_id = reader.GetInt32(reader.GetOrdinal("Category_id")),
                 };
                Foods.Add(temp);


            }
            conn.Close();
            return Foods;
        }



    }
}
