using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryWeb.Domain.Models
{
    [Table("BatchIngredients")]
    public class BatchIngredient
    {
        public int BatchIngredientId { get; set; }
        public int IngredientQuantity { get; set; }
        public int BatchId { get; set; }
        public Batch? Batch { get; set; }
        public int IngredientId { get; set; }
        public Ingredient? Ingredient { get; set; }
    }
}
