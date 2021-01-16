using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class Delivery
    {
        public int DeliveryId;
        public string DeliveryTypeName;
        public double DeliveryPrice;
        public ICollection<Order> DeliveryOrdersList;
    }
}
