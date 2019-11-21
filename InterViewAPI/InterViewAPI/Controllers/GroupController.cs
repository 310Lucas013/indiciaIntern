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
        // GET: Group/plain
        [HttpGet]
        [Route("plain")]
        public List<string> Get()
        {
            List<string> result = new List<string>();
            var arr = RandomNumbers();
            var q = from int e in arr select e;
            List<int> numbers = q.ToList<int>();
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

        // GET: Group/json
        [HttpGet]
        [Route("json")]
        public string Json()
        {
            List<Result> results = new List<Result>();
            var arr = RandomNumbers();
            var q = from int e in arr select e;
            List<int> numbers = q.ToList<int>();
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
            results = results.OrderBy(x => x.Total).ToList();
            string result = JsonConvert.SerializeObject(results);
            Console.WriteLine(result);
            return result;
        }

        // Supplied Code
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
