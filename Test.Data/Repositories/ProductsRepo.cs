using System;
using System.Collections.Generic;
using System.Linq;
using Test.Data.Models;

namespace Test.Data.Repositories
{
    public class ProductsRepo
    {
        private ProductsDB _db;
        public ProductsRepo(ProductsDB db)
        {
            _db = db;
        }

        public List<Product> GetAll()
        {
            return _db.Products.ToList();
        }
    }
}
