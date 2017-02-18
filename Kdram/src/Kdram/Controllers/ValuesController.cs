using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kdram.BussinesLogic;
using Kdram.DbMap.Entities;
using Kdram.Abstraction;

namespace Kdram.Controllers
{   
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //public ValuesController(IHumanResultService humanResultService)
        //{

        //}      
        #region GET api/values
            [HttpGet]
            public IActionResult Get()
            {
                HumanResultService result = new HumanResultService();
                var model = result.GetAllHumans().ToList();
                return Json(model);          
            }
        #endregion

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
