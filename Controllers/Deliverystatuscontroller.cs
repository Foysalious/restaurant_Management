using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_management.Models;
namespace Restaurant_management.Controllers
{
    public class Deliverystatuscontroller
    {
        static Database db = new Database();
        public static void ADDDeliveryStatus( String Oid, string Delivery_status)
        {
            Deliverystats d = new Deliverystats();
            d.OrderNo = Oid;
            d.Delivery_Status = Delivery_status;

            db.DeliveryStatus.ADDDeliveryStatus(d);


        }

        public static ArrayList GetAllstatus()
        {
            return db.DeliveryStatus.GetAllstatus();
        }

    }
}
