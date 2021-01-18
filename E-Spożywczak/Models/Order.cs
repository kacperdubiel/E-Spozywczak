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
        public int Id { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime OrderDate { get; set; }

        public TypeOfPayment TypeOfPayment { get; set; }
        public bool IsOrderPaid { get; set; }
        public DateTime OrderPaymentDate { get; set; }

        // Foreign
        public int DeliveryId { get; set; }
        public Delivery Delivery { get; set; }

        public int CartId { get; set; }
        public Cart Cart { get; set; }

        public int OrdersHistoryId { get; set; }
        public OrdersHistory OrdersHistory { get; set; }
    }
}
