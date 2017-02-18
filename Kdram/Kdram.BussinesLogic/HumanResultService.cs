using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdram.Abstraction;
using Kdram.DataAccess;
using Kdram.DbMap.Entities;

namespace Kdram.BussinesLogic
{
    public class HumanResultService : IHumanResultService
    {
        #region Get All Humans
            public IEnumerable<Human> GetAllHumans()
            {
               var result = RepositoryFactory.HumanResult.GetAllHumans();

               return result;
            }      
        #endregion
    }
}
