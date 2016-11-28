using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.DAL.Interfaces;
using Store.DAL.Entities;
using Store.DAL.EfContext;
using System.Data.Entity;

namespace Store.DAL.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private StoreContext db;
        public ProductRepository(StoreContext db)
        {
            this.db = db;            
        }

        public void Create(Product Product)
        {
            db.Products.Add(Product);
        }

        public void Delete(int id)
        {
            Product product = db.Products.Find(id);
            if (product != null)
                db.Products.Remove(product);
        }

        public IEnumerable<Product> Find(Func<Product, bool> predicate)
        {
            return db.Products.Where(predicate).ToList();
        }

        public Product Get(int id)
        {
            return db.Products.SqlQuery("Select * from Products where Id=@p",id).Single();
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products.SqlQuery("Select * from Products");
        }

        public void Update(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
        }
    }
}
