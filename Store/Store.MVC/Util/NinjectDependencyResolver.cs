using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Injection;
using System.Web.Mvc;
using Store.BLL.Interfaces;
using Store.BLL.Services;
namespace Store.MVC.Util
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel Kernel;
        public NinjectDependencyResolver(IKernel Kernelparam)
        {
            this.Kernel = Kernelparam;
            AddBindings();
        }

        object IDependencyResolver.GetService(Type serviceType)
        {
            return Kernel.TryGet(serviceType);
        }

        IEnumerable<object> IDependencyResolver.GetServices(Type serviceType)
        {
            return Kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            Kernel.Bind<IProductService>().To<ProductService>();           
        }
    }
}