using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdram.DbMap.Context;

namespace Kdram.DataAccess.Repositories
{
    internal abstract class BaseResultRepository
    {
        private static KdramContext context;
        
        protected KdramContext Context
        {
            get
            {
                return context ?? (context = new KdramContext());
            }
        }
        public BaseRepository(KdramContext Context)
        {
            this.Context = Context;
        }

        private readonly KdramContext Context;
    }    
}
