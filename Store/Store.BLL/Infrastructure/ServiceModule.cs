using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Store.DAL.Interfaces;
using Store.DAL.Repositories;

namespace Store.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfwork>().To<UnitOfWork>().InSingletonScope();
        }
    }
}
