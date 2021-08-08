using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysChallenge
{
    public class Day10
    {
        public static string GetBase2(int input)
            => Convert.ToString(input, 2);

        public static int CountTotalConsecutiveOne(int input)
        {
            var result = GetBase2(input);
            var data = result.Split('0');
            var ss = data.OrderBy(a => a.ToString().Length).Last();
            return ss.Length;
        }

    }
}
