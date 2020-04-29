using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_management.Models;
namespace Restaurant_management.Controllers
{
    class LoginController
    {
        static Database db = new Database();
        static public bool AuthenticateUser(string Username, string Password)
        {
            bool result = false;

            var obj = db.Admins.AuthenticateUser(Username, Password);


            if (obj != null) result = true;
            return result;

        }
        public static void ChanagePassword(String Email,String Password)
        {
            Admin b= new Admin();
            b.Email= Email;
            b.Password = Password;
            db.Admins.ChangePassword(b);
        }


    }
}
