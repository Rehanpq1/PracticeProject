using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using BL_Core.Controllers;
using BL_Core.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI.Controllers
{
    [Produces("application/json")]
    [Microsoft.AspNetCore.Mvc.Route("api/MVC")]
    public class MVCController : Controller
    {
        StudentDB objDB = new StudentDB();

        //[Microsoft.AspNetCore.Mvc.HttpGet]
        // GET: Default
        public IEnumerable<Student> GetStudents()
        {

            // GET: api/Student
            List<Student> students = objDB.GetDetail(); 

            return students;
        }
    }
}