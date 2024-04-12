using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryWeb.Domain.Models
{
    [Table("Ingredients")]
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int StockQuantity { get; set; }
        public string? Name { get; set; }
    }
}
