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
        // GET: formateer/sommatie
        [HttpGet]
        public string Get()
        {
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
            Console.WriteLine(input);
            return input;
        }

        // Supplied values.
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
