using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Kdram.Abstraction
{
    public interface IHumanResultService
    {
       IEnumerable GetAllHumans();
    }
}
