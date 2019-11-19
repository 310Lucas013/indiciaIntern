using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterViewAPI.Controllers
{
    [Route("[controller]/sommatie")]
    [ApiController]
    public class FormateerController : ControllerBase
    {
        // GET: api/Formateer
        [HttpGet]
        public string Get()
        {
            string pattern = @"\p{Sc}*(\s?\d+[.,]?\d*)\p{Sc}*";
            string replacement = "$1";
            string input = "";
            foreach (object obj in InputValues())
            {
                if (obj != null)
                {
                    input += ojb
                }
            }
            //string input = InputValues().ToString();
            return input;
        }

        // GET: api/Formateer/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Formateer
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Formateer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private static object[] InputValues()

        {

            return new[]

            {

                "5",

                "1,2e2",

                null,

                " -5555",

                "6.767"

            };

        }
    }
}
