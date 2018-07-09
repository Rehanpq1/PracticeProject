using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BL_Core.Controllers;
using BL_Core.Database;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreAPI.Controllers
{
    [Route("api/[controller]")]
    public class EmpController : Controller
    {
        EmpDB objDB = new EmpDB();

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Emp> Get()
        {

            var listdata = objDB.GetDetail();
            return listdata;
        }

        /// <summary>
        /// Use HttpResponse stead of string so that it would be easy ready data
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Emp Get(int id)
        {
            var listdata = objDB.GetDetail();
            return listdata.Where(l => l.Id == id).First();
        }

        // POST api/<controller>
        [HttpPost]
        public int Post([FromBody]Emp objEMP)
        {
            return objDB.InsertValues(objEMP.Id, objEMP.Name);
        }

        /// <summary>
        /// Use FromUri to pass parameter in URI like query string 
        /// </summary>
        /// <param name="objEMP"> 
        /// http://localhost:64955/api/emp/id=2&FoodName=Banana
        /// </param>
        /// <returns></returns>
        [HttpPost("{ID,FoodName}")]
        public int PostURI([System.Web.Http.FromUri]Emp objEMP)
        {
            return objDB.InsertValues(objEMP.Id, objEMP.Name);
        }
    
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public int Put(int id, [FromBody]Emp objEMP)
        {
            return objDB.InsertValues(objEMP.Id, objEMP.Name);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return objDB.DeleteValues(id);
        }
    }
}
