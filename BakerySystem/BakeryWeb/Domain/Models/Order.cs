using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryWeb.Domain.Models
{
    [Table("Orders")]
    public class Order
    {
        public int OrderId { get; set; }
        public int SupermarketId { get; set; }
        public Supermarket? Supermarket { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string? OrderNumber { get; set; }
        public string? BakingGoods { get; set; }
        public int Quantity { get; set; }
    }
}

