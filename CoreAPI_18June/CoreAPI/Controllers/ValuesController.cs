using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL_Core.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private List<Emp> list = new List<Emp>
        {
            new Emp{Name ="Coconet",Id=1},
            new Emp{Name ="Banana",Id=2},
            new Emp{Name ="Orange",Id=3},
            new Emp{Name ="Mango",Id=4},
            new Emp{Name ="Pinapple",Id=5},
        };

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Emp> Get()
        {
            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return list.Where(l => l.Id == id).Select(l => l.Name).First().ToString();
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
