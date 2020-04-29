using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurant_management.Models
{
   public  class Categories
    {
        SqlConnection conn;
        public Categories()
        {
            conn = new SqlConnection("Server=FOYSAL\\SQLEXPRESS;Database=test;Integrated Security=True;");
        }

        public Category GetCategory(string categoryName)
        {
            Category c = new Category();
            return c;
        }
        public ArrayList GetAllCategories()
        {
            ArrayList Categories = new ArrayList();

            conn.Open();
            string query = "SELECT * FROM Categories";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Category temp = new Category();
                temp.Category_id = reader.GetInt32(reader.GetOrdinal("Category_id"));
                temp.Category_name = reader.GetString(reader.GetOrdinal("Category_name"));
                Categories.Add(temp);

            }
            conn.Close();
            return Categories; 
        }
    }
}
