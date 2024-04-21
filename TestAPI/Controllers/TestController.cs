using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Runtime.Serialization.Json;

namespace TestAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/<TestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpGet("{id}/{Name}/{Age}")]
        public string Get(int id, string Name, string Age)
        {
            
            return string.Concat(Name, id);
        }

        [HttpGet("{id}, {Name}")]
        public string Get(int id, string Name)
        {
            return string.Concat(Name, id);
        }

        [HttpGet("Name/{Name}/Age/{age}")]
        public EmployeeData Get(string Name, int age)
        {
            try
            {
                return EmployeeData.GetEmployeeById(1);

            }
            catch
            {
                return null;
            }

















        }


        //[HttpGet("war")]
        //public IEnumerable<string> Get([FromBody] TestClass test)
        //{
        //    List<string> list = new List<string>();
        //    list.AddRange(new string[]
        //    {
        //        test.id.ToString(),
        //        test.Name,
        //        test.Age,
        //        test.City,
        //        test.Salary.ToString(),
        //        test.Region.ToString(),
        //        "India"
        //    });
        //    return list;
        //}


        // POST api/<TestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
