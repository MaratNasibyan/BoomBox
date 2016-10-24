using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.BLL.DTO;

namespace Store.BLL.Interfaces
{
    interface IProductService
    {
        void MakeProduct(ProductDTO productDTO);
        ProductDTO GetProduct(int? Id);
        IEnumerable<ProductDTO> GetAll();
        void Dispose();
    }
}
