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
        // Primary
        [Key]
        public int Id;
        public string DeliveryAddress;
        public DateTime OrderDate;

        public TypeOfPayment TypeOfPayment;
        public bool IsOrderPaid;
        public DateTime OrderPaymentDate;

        // Foreign
        public int DeliveryId;
        public Delivery Delivery;

        public int CartId;
        public Cart Cart;

        public int OrdersHistoryId;
        public OrdersHistory OrdersHistory;
    }
}
