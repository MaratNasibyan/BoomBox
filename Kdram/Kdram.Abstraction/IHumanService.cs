using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdram.DbMap.Context;

namespace Kdram.Abstraction
{
    public interface IHumanService
    {
       IEnumerable<Human> GetAllHumans();
    }
}
