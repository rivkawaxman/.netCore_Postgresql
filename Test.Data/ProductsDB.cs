using System;
using Microsoft.EntityFrameworkCore;
using Test.Data.Models;

namespace Test.Data
{
    public class ProductsDB:DbContext
    {

        public ProductsDB(DbContextOptions<ProductsDB> options)
            :base(options)
        {
        }

        public DbSet<Product>Products  {
            get;
            set;
        }
    }
}
