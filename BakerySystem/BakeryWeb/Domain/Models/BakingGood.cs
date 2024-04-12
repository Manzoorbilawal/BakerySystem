using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryWeb.Domain.Models
{
    [Table("BakingGoods")]
    public class BakingGood
    {
        [Key]
        public int? BakingGoodId { get; set; }
        public string? Name { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
