using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InterViewAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET fizzbuzz/values/5
        [HttpGet]
        public ActionResult<List<string>> Get(int from, int to)
        {
            List<string> result = new List<string>();
            for (int i = from; i <= to; i++)
            {
                String value = "";
                if (i % 3 == 0)
                {
                    value += "Fizz";
                }

                if (i % 5 == 0)
                {
                    value += "Buzz";
                }

                if (value == "")
                {
                    value = i.ToString();
                }
                Console.WriteLine(value);
                result.Add(value);
            }
            
            return result;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
