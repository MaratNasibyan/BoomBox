using System;
using System.Collections.Generic;
using System.Text;
using DbMap.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataAccess.Abstraction;

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
            return  context.Product;
        }
    }
}
