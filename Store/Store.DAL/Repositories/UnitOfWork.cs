using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.DAL.EfContext;
using Store.DAL.Entities;
using Store.DAL.Interfaces;

namespace Store.DAL.Repositories
{
    public class UnitOfWork : IUnitOfwork
    {
        private StoreContext db = new StoreContext();
        private ProductRepository productRepository;

        public ProductRepository Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(db);
                return productRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false;        

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {              
                    db.Dispose();
                }           

                disposedValue = true;
            }
        }
        
        public void Dispose()
        {            
            Dispose(true);           
        }
        #endregion

    }
}
