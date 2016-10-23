using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.DAL.Entities;
using Store.DAL.Interfaces;
using Store.DAL.Repositories;
using Store.DAL.EfContext;
namespace Store.DAL.Interfaces
{
    interface IUnitOfwork:IDisposable
    {
        ProductRepository Products { get;}
        void Save();
    }
}
