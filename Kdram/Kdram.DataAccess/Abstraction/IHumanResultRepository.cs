using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdram.DbMap.Entities;

namespace Kdram.DataAccess.Abstraction
{
    public interface IHumanResultRepository
    {
        IEnumerable<Human>  GetAllHumans();
    }
}
