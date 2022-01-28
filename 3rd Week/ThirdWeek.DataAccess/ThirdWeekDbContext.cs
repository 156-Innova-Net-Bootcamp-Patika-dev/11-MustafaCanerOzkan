using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdWeekModel.Entities;

namespace ThirdWeek.DataAccess
{
    public class ThirdWeekDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Veritabanı ile bağlantı kuracağımız kısım.
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ThirdWeekDb;uid=sa;pwd=1234");
        }

        // Veritabanında oluşacak olan tablolarımızı tanımlıyoruz.
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
