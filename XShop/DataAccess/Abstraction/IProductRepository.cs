using System;
using System.Collections.Generic;
using System.Text;
using DbMap.Entities;


namespace DataAccess.Abstraction
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProduct();
    }
}
