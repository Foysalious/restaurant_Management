using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management.Models
{
    public class Database
    {

        public Admins Admins { get; set; }
        public Customers Customers { get; set; }
        public Foods Foods { get; set; }
        public Categories Categories { get; set; }
        public Employees Employees { get; set; }
        public Deliverymans Deliverymans { get; set; }
        public Purchases Purchases { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }
        public Database()
        {
            Admins = new Admins();
            Customers = new Customers();
            Foods = new Foods();
            Categories = new Categories();
            Employees = new Employees();
            Deliverymans = new Deliverymans();
            Purchases = new Purchases();
            DeliveryStatus = new DeliveryStatus();
        }

    }
}

