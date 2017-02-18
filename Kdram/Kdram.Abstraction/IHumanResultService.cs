using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using Kdram.DbMap.Entities;

namespace Kdram.Abstraction
{
    public interface IHumanResultService
    {
       IEnumerable<Human> GetAllHumans();
    }
}
