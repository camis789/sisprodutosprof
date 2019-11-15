using System;
using Microsoft.EntityFrameworkCore;
using SisProdutos.models;

namespace SisProdutos.Config
{
    public class DbContextProduct : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=34.67.49.201;DataBase=SisProduct;Uid=admin;Pwd=Admin@2019;");
        }
    }
}
