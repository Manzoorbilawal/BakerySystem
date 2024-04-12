using BakeryWeb.Domain.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BakeryWeb.Data
{
    public class MyDbContext : DbContext
    {
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = 127.0.0.1; Initial Catalog = BakerySystemDatabase; User ID = sa; Trust Server Certificate = True");
        }
        public DbSet<Batch> Batchs { get; set; }
        public DbSet<BatchIngredient> BatchIngredients { get; set; }
        public DbSet<BakingGood> BakingGoods { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Packet> Packets { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<DispatchSheet> DispatchSheets { get; set; }
    }
}