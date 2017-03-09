using System;
using System.Linq;


namespace TestConsole
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] types_temp = Console.ReadLine().Split(' ');
            int[] list = Array.ConvertAll(types_temp, Int32.Parse);

            int lastBirdTypeTotal = 0;
            int birdType = 0;
            var uniqueList = list.Distinct().ToList();
            for (int i = 0; i < uniqueList.Count(); i++)
            {
                var typeTotal = list.Where(a => a == uniqueList[i]).Count();
                if (typeTotal > lastBirdTypeTotal)
                {
                    lastBirdTypeTotal = typeTotal;
                    birdType = uniqueList[i];
                }
                else if (typeTotal == lastBirdTypeTotal)
                {
                    if (uniqueList[i] < birdType)
                    {
                        birdType = uniqueList[i];
                    }
                }
            }
            Console.WriteLine(birdType);
        }
    }
}
