using System;
using System.Collections.Generic;
using System.Text;
using DbMap.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataAccess.Abstraction;
using System.Linq;

namespace DataAccess.Repositories
{
    public  class ProductRepositories : IProductRepository
    {
        ShopContext context = new ShopContext();
        public ProductRepositories()
        {
           
        }

        public IEnumerable<Product> GetProduct()
        {
            return context.Product.FromSql("GetProducts");
        }

        public void f()
        {
            //var v = context.Product.Where(n=>n.)
        }
    }
}
