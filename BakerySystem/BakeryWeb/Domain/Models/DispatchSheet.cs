using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryWeb.Domain.Models
{
    [Table("DispatchSheets")]
    public class DispatchSheet
    {
        public int? DispatchSheetId { get; set; }
        public string? Route { get; set; }
        public int? PacketId { get; set; }
        public Packet? Packet { get; set; }
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
    }
}

