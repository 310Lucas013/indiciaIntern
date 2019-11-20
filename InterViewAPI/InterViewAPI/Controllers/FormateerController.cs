using System;
using System.Collections.Generic;
using System.Globalization;
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
            //List<double[]> doubles = (double[])InputValues()
            //double SumNumbers(List<double[]> setsOfNumbers, int indexOfSetToSum)
            //{
            //    return setsOfNumbers?[indexOfSetToSum]?.Sum() ?? double.NaN;
            //}

            //var sum = SumNumbers(null, 0);


            //string pattern = @"\p{Sc}*(\s?\d+[.,]?\d*)\p{Sc}*";
            //string replacement = "$1";
            //string input = "";
            //foreach (object obj in InputValues())
            //{
            //    if (obj != null)
            //    {
            //        input += ojb
            //    }
            //}
            //string input = InputValues().ToString();

            string input = "";
            double inputTotal = 0;
            object[] inputNumbers = InputValues();
            foreach(object obj in inputNumbers)
            {
                if (obj != null)
                {
                    inputTotal += Convert.ToDouble(obj.ToString());
                }
            }
            inputTotal = inputTotal / 1000;
            input = inputTotal.ToString("N3", CultureInfo.CreateSpecificCulture("en-US"));
                //String.Format("D", inputTotal/ 1000);
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
