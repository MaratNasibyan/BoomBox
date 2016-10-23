using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using Store.DAL.Entities;

namespace Store.DAL.EfContext
{
    public class StoreContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public StoreContext():base("DefaultConnection")
        {
            
        }
        public class StoreDbInitializer : DropCreateDatabaseAlways<StoreContext>
        {
            protected override void Seed(StoreContext db)
            {
                db.Products.Add(new Product { Name = "Snickers", Price = 220M });               
                db.SaveChanges();
            }
        }
    }
}
