using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Restaurant_management.Models
{
   public class Purchases
    {
        SqlConnection conn;
        public Purchases()
        {
            conn = new SqlConnection("Server=FOYSAL\\SQLEXPRESS;Database=test;Integrated Security=True;");
        }
        public void NewPurchases(Purchase Purchase)
        {

            conn.Open();
            string query = "INSERT INTO Purchases (FName,Phone,Address,Customer_name,Price) VALUES('" + Purchase.FName + "','" + Purchase.Phone + "','" + Purchase.Address + "' ,'" + Purchase.Customer_name + "','"+Purchase.Price+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }
        public Purchase GetFood(string FName)
        {
            Purchase f = new Purchase();
            return f;

        }
        public ArrayList GetAllOrder()
        {
            ArrayList Purchases = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Purchases";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Purchase u = new Purchase()
                {
                    Order_no = reader.GetInt32(reader.GetOrdinal("Order_no")),
                    FName = reader.GetString(reader.GetOrdinal("FName")),
                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                    Address = reader.GetString(reader.GetOrdinal("Address")),
                    Customer_name = reader.GetString(reader.GetOrdinal("Customer_name")),

                };
                Purchases.Add(u);
            }
            conn.Close();
            return Purchases;
        }
       
    }
}
