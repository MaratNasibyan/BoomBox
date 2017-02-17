using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdram.DataAccess.Abstraction;
using Kdram.DbMap.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections;


namespace Kdram.DataAccess.Repositories
{
    public class HumanResultRepository : BaseResultRepository, IHumanResultRepository
    {
        IEnumerable<Human> IHumanResultRepository.GetAllHumans()
        {
            return this.KdramResultsEntities.Human.ToList();
        }
    }
}
