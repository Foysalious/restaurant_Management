using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_management.Models;

namespace Restaurant_management.Controllers
{
   public class CategoryController
    {
        static Database db = new Database();
        public static ArrayList GetAllCategories()
        {
            return db.Categories.GetAllCategories();
        }
    }
}
