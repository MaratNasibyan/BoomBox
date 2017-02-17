using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kdram.DataAccess.Abstraction;
using Kdram.DataAccess.Repositories;

namespace Kdram.DataAccess
{
    public static class RepositoryFactory
    {
        private static IHumanResultRepository humanResult;

        public static IHumanResultRepository HumanResult
        {
            get
            {
                return humanResult ?? (humanResult = new HumanResultRepository());
            }
        }
    }
}
