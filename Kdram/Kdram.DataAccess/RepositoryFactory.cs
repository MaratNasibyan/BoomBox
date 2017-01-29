using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Kdram.DataAccess
{
    public class RepositoryFactory
    {
        public RepositoryFactory()
        {
            Kdram.DbMap.Context.KdramContext c = new DbMap.Context.KdramContext();         
        }
    }
}
