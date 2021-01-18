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
        [Display(Name = "ID zamówienia")]
        public int Id { get; set; }

        [Display(Name = "Adres")]
        public string DeliveryAddress { get; set; }

        [Display(Name = "Data")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Typ płatności")]
        public TypeOfPayment TypeOfPayment { get; set; }

        [Display(Name = "Stan płatności")]
        public bool IsOrderPaid { get; set; }
        public DateTime OrderPaymentDate { get; set; }

        // Foreign
        [Display(Name = "ID dostawy")]
        public int DeliveryId { get; set; }

        [Display(Name = "Dostawa")]
        public Delivery Delivery { get; set; }

        [Display(Name = "ID koszyka")]
        public int CartId { get; set; }

        [Display(Name = "Koszyk")]
        public Cart Cart { get; set; }

        [Display(Name = "ID historii")]
        public int OrdersHistoryId { get; set; }
        [Display(Name = "Historia")]
        public OrdersHistory OrdersHistory { get; set; }
    }
}
