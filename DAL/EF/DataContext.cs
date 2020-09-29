using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;


namespace DAL.EF
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; } //всі продукти

        public DbSet<Order> Orders { get; set; }  //історія замовлень
       
        public DbSet<PersonalDiscount> PersonalDiscounts { get; set; }

        public DataContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=STARODUB;Initial Catalog=ConsolePro;User Id = sa; Password = sa");
        }
    }


}
