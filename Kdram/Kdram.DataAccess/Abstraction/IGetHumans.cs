using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kdram.DataAccess.Abstraction
{
    interface IGetHumans<T> where T : class
    {
        IEnumerable<T> GetAllHumans();
    }
}
