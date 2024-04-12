using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryWeb.Domain.Models
{
    [Table("Batchs")]
    public class Batch
    {
        public int BatchId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime TargetFinishTime { get; set; }
        public int Quantity { get; set; }
        public string? BatchNumber { get; set; }
        public int IngredientId { get; set; }
        public Ingredient? Ingredient { get; set; }
    }
}
