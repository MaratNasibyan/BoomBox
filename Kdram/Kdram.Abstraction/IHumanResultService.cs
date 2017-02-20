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
    
   
    /*public interface IOrgResultsLogService
    {
        void Error<T>(T value, UserInfo userInfo);

        void Error(string message);

        void Info(string infoMessage);
    }
    */
    
}
