using System.Collections.Generic;
using System.Linq;
using Kdram.Abstraction;
using Kdram.DataAccess;
using Kdram.DbMap.Entities;
using Kdram.Models;

namespace Kdram.BussinesLogic
{
    public class HumanResultService : BaseService, IHumanResultService
    {
        #region Get All Humans
        public IEnumerable<Human> GetAllHumans()
        {
            IList<HumanViewModel> models = new List<HumanViewModel>();

            var result = RepositoryFactory.HumanResult
                        .GetAllHumans()
                        .Where(x => x.Isn == 1)
                        .ToList(); 

            foreach(var model in result)
            {
                models.Add(new HumanViewModel
                {
                    Name = model.Name,
                    Surname = model.Surname
                });                
            }

            return result;
        }      
        #endregion
    }
}
