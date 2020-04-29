using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_management.Models;

namespace Restaurant_management.Controllers
{
    public class EmployeeController
    {
        static Database db = new Database();
        public static void AddEmployees(string Name, string Username, string Password, string Email, string Address, string Phone, string Gander,string DOB)
        {
            Employee c = new Employee();
            c.Name = Name;
            c.Password = Password;
            c.Username = Username;
            c.Email = Email;
            c.Phone = Phone;
            c.Address = Address;
            c.Gander = Gander;
            c.DOB = DOB;

            db.Employees.AddEmployees(c);
        }
        public static void DeleteEmployees(string Name)
        {
            Employee c = new Employee();
            c.Name = Name;
            db.Employees.DeleteEmployees(c);
        }
        static public bool AuthenticateUser(string Username, string Password)
        {
            bool result = false;

            var obj = db.Employees.AuthenticateUser(Username, Password);


            if (obj != null) result = true;
            return result;

        }


        public static void ChanagePassword(String Email, String Password)
        {
            Employee d = new Employee();
            d.Email = Email;
            d.Password = Password;
            db.Employees.ChangePassword(d);
        }
    }
}
