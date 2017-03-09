using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysChallenge
{
    public class Day7
    {
        public static void MainMethod()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            var total = (n - 1) + (m - 1);
            Console.WriteLine(total);
            Console.ReadLine();
        }
        
    }
}
