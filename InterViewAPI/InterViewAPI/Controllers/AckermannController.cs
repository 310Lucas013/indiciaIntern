using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterViewAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AckermannController : ControllerBase
    {
        [HttpGet]
        [Route("calculate")]
        public int Get(int a, int b)
        {
            return Ackermanns(a, b);
        }

        // POST: api/Ackermann
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Ackermann/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private int Ackermanns(int a, int b)
        {
            if (a == 0)
            {
                return b + 1;
            }
            else if (a > 0 && b == 0) return Ackermanns((a - 1), 1);
            else if (a > 0 && b > 0) return Ackermanns((a - 1), Ackermanns(a, (b - 1)));
            else
            {
                throw new System.ArgumentOutOfRangeException();
            }
        }
    }
}
