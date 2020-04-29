using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurant_management.Models
{
    
        
   public class DeliveryStatus
    {
        SqlConnection conn;

        public DeliveryStatus()
        {
            conn = new SqlConnection("Server=FOYSAL\\SQLEXPRESS;Database=test;Integrated Security=True;");
        }

        public void ADDDeliveryStatus(Deliverystats Deliverystats)
        {

            conn.Open();
            string query = "INSERT INTO DeliveryStatus (OrderNO,Delivery_Status) VALUES('"+ Deliverystats.OrderNo+ "','"+ Deliverystats.Delivery_Status+ "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }

        public Deliverystats Getstatus(string Delivery_Status)
        {
            Deliverystats f = new Deliverystats();
            return f;

        }
        public ArrayList GetAllstatus()
        {
            ArrayList DeliveryStatus = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM DeliveryStatus";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Deliverystats d = new Deliverystats()
                {

                    OrderNo = reader.GetString(reader.GetOrdinal("OrderNO")),
                    Delivery_Status = reader.GetString(reader.GetOrdinal("Delivery_Status")),
                    

                };
                DeliveryStatus.Add(d);
            }
            conn.Close();
            return DeliveryStatus;
        }

    }
}
