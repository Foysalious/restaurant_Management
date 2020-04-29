using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_management.Models;
namespace Restaurant_management.Controllers
{
   public class CustomerController
    {

        static Database db = new Database();
        public static void AddCustomers(string Name, string Username, string Password,string Email, string Address,string Phone,string Gander,string DOB)
        {
            Customer c = new Customer();
            c.Name = Name;
            c.Password = Password;
            c.Username = Username;
            c.Email = Email;
            c.Phone = Phone;
            c.Address = Address;
            c.Gander = Gander;
            c.DOB = DOB;


            db.Customers.AddCustomers(c);
        }
        public static void DeleteCustomers(string Name)
        {
            Customer c = new Customer();
            c.Name = Name;
            db.Customers.DeleteCustomers(c);
        }
        static public bool AuthenticateUser(string Username, string Password)
        {
            bool result = false;

            var obj = db.Customers.AuthenticateUser(Username, Password);


            if (obj != null) result = true;
            return result;

        }


        public static void ChanagePassword(String Email, String Password)
        {
            Customer d = new Customer();
            d.Email = Email;
            d.Password = Password;
            db.Customers.ChangePassword(d);
        }

    }
}
