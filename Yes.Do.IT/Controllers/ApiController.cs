using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yes.Do.IT.Controllers
{
	public class ApiController : Controller
	{
        // GET: /<controller>/
        // GET: api/student
        public IEnumerable<string> Get()
        {
            return new string[] { "", "" };
        }

        // GET: api/student/5
        public string Get(int Id)
        {
            return "value";
        }

        // POST: api/
        public void Post([FromBody]string value)
        {
            
        }

        // PUT: api/
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/
        public void Delete(int id)
        {
        }
    }
}
