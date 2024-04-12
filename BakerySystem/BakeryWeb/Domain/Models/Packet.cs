using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryWeb.Domain.Models
{
    [Table("Packets")]
    public class Packet
    {
        public int? PacketId { get; set; }
        public int? Quantity { get; set; }
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
        public int? BakingGoodId { get; set; }
        public BakingGood? BakingGood { get; set; }
    }
}
