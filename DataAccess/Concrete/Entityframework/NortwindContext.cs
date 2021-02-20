
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Entityframework
{
    //Context: Db tabloları ile proje classlarını bağlamak için kullanılır.
    public class NortwindContext: DbContext
    {
        //Veritabanımın yeri
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AYAZ-LAPTOP;Database=Northwind;integrated security=true");
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
