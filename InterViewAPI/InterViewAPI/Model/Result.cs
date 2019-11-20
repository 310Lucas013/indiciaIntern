using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterViewAPI.Model
{
    public class Result
    {
        public int Key { get; }
        public int Total { get; }

        public Result(int key, int total)
        {
            Key = key;
            Total = total;
        }
    }
}
