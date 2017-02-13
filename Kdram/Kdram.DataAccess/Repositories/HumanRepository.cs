using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdram.DataAccess.Abstraction;
using Kdram.DbMap.Context;

namespace Kdram.DataAccess.Repositories
{
    public class HumanResultRepository : BaseResultRepository, IHumanResultRepository
    {
        public HumanRepository(KdramContext Context) : base(Context)
        {
            this.Context = Context;
        }

        public IEnumerable<Human> GetAllHumans()
        {
            return Context.Human.ToList();
        }

        private readonly KdramContext Context;
    }
}
