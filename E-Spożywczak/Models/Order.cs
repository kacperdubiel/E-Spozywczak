using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public enum TypeOfPayment
    {
        Electronic,
        OnDelivery
    }
    public class Order
    {
        [Key]
        public int OrderId;
        public string OrderAddress;
        public int OrderDeliveryId;
        public Delivery OrderDelivery;
        public DateTime OrderDate;
        public TypeOfPayment OrderTypeOfPayment;
        public bool IsOrderPaid;
        public DateTime OrderPaymentDate;
        public Cart OrderCart; 
        public OrdersHistory OrderOrdersHistory;
    }
}
