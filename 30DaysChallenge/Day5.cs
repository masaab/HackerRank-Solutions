using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysChallenge
{
    public class Day5
    {
       
        public static void MainMethod()
        {
            int limit = 10;
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine($"{input} x {i} = {input * i}");
            }
            Console.ReadLine();
        }
        
    }
}
