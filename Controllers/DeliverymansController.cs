using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_management.Models;
namespace Restaurant_management.Controllers
{
    public class DeliverymansController
    {
        static Database db = new Database();
        public static void AddDeliverymans(string Name, string Username, string Password, string Email, string Address, string Phone, string Gander,string DOB)
        {
            Deliveryman c = new Deliveryman();
            c.Name = Name;
            c.Password = Password;
            c.Username = Username;
            c.Email = Email;
            c.Phone = Phone;
            c.Address = Address;
            c.Gander = Gander;
            c.DOB = DOB;

            db.Deliverymans.AddDeliverymans(c);
        }
        public static void DeleteDeliverymans(string Name)
        {
            Deliveryman c = new Deliveryman();
            c.Name = Name;
            db.Deliverymans.DeleteDeliverymans(c);
        }
        static public bool AuthenticateUser(string Username, string Password)
        {
            bool result = false;

            var obj = db.Deliverymans.AuthenticateUser(Username, Password);


            if (obj != null) result = true;
            return result;

        }


        public static void ChanagePassword(String Email, String Password)
        {
            Deliveryman d = new Deliveryman();
            d.Email = Email;
            d.Password = Password;
            db.Deliverymans.ChangePassword(d);
        }


    }
}
