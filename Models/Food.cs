using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management.Models
{
   public class Food
    {
        public int F_id { get; set; }
        public string Food_Name { get; set; }
        public string Food_Price { get; set; }
        public int Category { get; set; }
        public string Availability { get; set; }
        public int Category_id { get; set; }


    }
}
