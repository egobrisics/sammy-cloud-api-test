using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SammyCloudData.DAL;
using SammyCloudData.Entities;

namespace SammyCloudAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            var result = IndexedValuesRepository.Get();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Json(result.Data);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IndexedValue Get(int id)
        {
            var result = IndexedValuesRepository.Get(id);
            return result.Data;
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
