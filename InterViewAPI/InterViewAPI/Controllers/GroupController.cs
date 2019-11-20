using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterViewAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace InterViewAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        // GET: api/Group
        [HttpGet]
        [Route("plain")]
        public List<string> Get()
        {
            List<string> result = new List<string>();
            var arr = RandomNumbers();
            var q = from int e in arr select e;
            List<int> numbers = q.ToList<int>();
            //List<int> numbers = arr.SelectMany(it => it).ToList();
            List<int[]> countedNumbers = new List<int[]>();
            for (int i = 24; i >= 0; i--)
            {
                int amount = numbers.Where(x => x == i).Count();
                int[] a = { i, amount };
                countedNumbers.Add(a);
            }
            foreach(int[] cn in countedNumbers)
            {
                string line = cn[0].ToString() + ": " + cn[1].ToString() + " keer";
                Console.WriteLine(line);
                result.Add(line);
            }
            return result;
        }

        [HttpGet]
        [Route("json")]
        public string Json()
        {
            List<Result> results = new List<Result>();
            var arr = RandomNumbers();
            var q = from int e in arr select e;
            List<int> numbers = q.ToList<int>();
            //List<int> numbers = arr.SelectMany(it => it).ToList();
            List<int[]> countedNumbers = new List<int[]>();
            for (int i = 24; i >= 0; i--)
            {
                int amount = numbers.Where(x => x == i).Count();
                int[] a = { i, amount };
                countedNumbers.Add(a);
            }
            foreach (int[] cn in countedNumbers)
            {
                string line = cn[0].ToString() + ": " + cn[1].ToString() + " keer";
                Console.WriteLine(line);
                results.Add(new Result(cn[0], cn[1]));
            }
            string result = JsonConvert.SerializeObject(results);
            Console.WriteLine(result);
            return result;
        }

        //// GET: api/Group/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Group
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Group/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private static IEnumerable<int> RandomNumbers(int seed = 123)
        {
            var random = new System.Random(seed);
            for (int i = 0; i < 1000; i++)
            {
                yield return random.Next(25);
            }
        }
    }
}
