using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BakerySystem
{
    public class MyDbContext : DbContext
    {
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = 127.0.0.1; Initial Catalog = BakerySystemDatabase; User ID = sa; Trust Server Certificate = True");
        }
    }
    //Db Sets come here…see later
}