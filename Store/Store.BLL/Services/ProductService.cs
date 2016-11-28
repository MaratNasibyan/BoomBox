using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.BLL.DTO;
using Store.BLL.Interfaces;
using Store.BLL.Infrastructure;
using Store.DAL.EfContext;
using Store.DAL.Repositories;
using Store.DAL.Entities;
using Store.DAL.Interfaces;
using AutoMapper;

namespace Store.BLL.Services
{   
    public class ProductService : IProductService
    {       
        public ProductService(UnitOfWork param)
        {
            this.u = param;            
        }
        public IEnumerable<ProductDTO> GetAll()
        {
            AutoMapper.Mapper.Initialize(n => n.CreateMap<Product, ProductDTO>());
            return Mapper.Map<IEnumerable<Product>, List<ProductDTO>>(u.Products.GetAll());
        }

        public ProductDTO GetProduct(int? Id)
        {
            if(Id==null)
            {
                throw new ValidationException("Id not found","");
            }
            var product = u.Products.Get(Id.Value);
            if(product==null)
            {
                throw new ValidationException("product not found", "");
            }
            Mapper.Initialize(n => n.CreateMap<Product, ProductDTO>());
            return Mapper.Map<Product, ProductDTO>(product);
        }

        public void MakeProduct(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            u.Dispose();
        }
             
        private readonly IUnitOfwork u;
    }
}
