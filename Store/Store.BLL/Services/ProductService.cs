using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.BLL.DTO;
using Store.BLL.Interfaces;
using Store.DAL.EfContext;
using Store.DAL.Repositories;

using AutoMapper;

namespace Store.BLL.Services
{
    
    public class ProductService : IProductService
    {
            
               
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductDTO GetProduct(int? Id)
        {
            throw new NotImplementedException();
        }

        public void MakeProduct(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }
    }
}
