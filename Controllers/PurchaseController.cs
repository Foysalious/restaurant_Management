using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_management.Models;
namespace Restaurant_management.Controllers
{
    public class PurchaseController
    {
        static Database db = new Database();

        public static void NewPurchases(string Name, string Address, string Phone,string  Customer_name, string Price)
        {
            Purchase c = new Purchase();
            c.FName = Name;
            c.Phone = Phone;
            c.Address = Address;
            c.Customer_name = Customer_name;
            c.Price = Price;

            db.Purchases.NewPurchases(c);
        }
        public static ArrayList GetAllOrder()
        {
            return db.Purchases.GetAllOrder();
        }

       
    }
}
