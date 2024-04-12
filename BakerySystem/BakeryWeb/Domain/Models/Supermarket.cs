using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryWeb.Domain.Models
{
    [Table("Supermarkets")]
    public class Supermarket
    {
        public int? SupermarketId { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set;}
    }
}
