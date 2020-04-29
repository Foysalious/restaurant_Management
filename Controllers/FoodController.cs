using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_management.Models;
namespace Restaurant_management.Controllers
{
   public class FoodController
    {
        static Database db = new Database();

        public static void AddFoods(string foodname, string foodprice, string ava,  int catId)
        {
            Food p = new Food()
            {
                Food_Name = foodname,
                Food_Price = foodprice,
                Availability = ava,
                Category_id = catId
           

            };
            db.Foods.AddFoods(p);

        }

        public static void UpdateFood(string foodname, string foodprice, string ava)
        {
            Food p = new Food()
            {
               
                Food_Name = foodname,
                Food_Price = foodprice,
                Availability = ava,
                


            };
            db.Foods.UpdateFood(p);

        }

        public static void DeleteFoods(string Name)
        {
            Food c = new Food();
            c.Food_Name = Name;
            db.Foods.UpdateFood(c);
        }
        public static ArrayList GetallFood()
        {
            return db.Foods.GetAllFoods();
        }
    }
}
