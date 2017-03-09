using _30DaysChallenge.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysChallenge
{
   public class Day4
    {
        public static void MainMethod()
        {
            var totalInputs = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[totalInputs];
            for (int i = 0; i < totalInputs; i++) 
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in arr)
            {
                Person person = new Person(i);
                person.amIOld();
                for (int j = 0; j < 3; j++) 
                {
                    person.yearPasses();
                }
                person.amIOld();
                Console.WriteLine();
            }
        }
    }
}
