using System;
using System.Linq;

namespace RandomHackerRank
{
    public class ArrayDS
    {
        public static void Result()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            arr.Reverse().ToList().ForEach(a => {
                Console.Write(a + " ");
            }); 
         
        }
    }
}
