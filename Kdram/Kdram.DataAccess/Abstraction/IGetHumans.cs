using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kdram.DataAccess.Abstraction
{
    public interface IHumanResultRepository
    {
        IEnumerable<T> GetAllHumans();
    }
}
