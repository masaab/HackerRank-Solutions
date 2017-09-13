using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHackerRank
{
    public class ReplenishBowl
    {
        public int GetTotalCandies()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int t = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            return GetTotalExtraCandiesAdded(n, c, t);
        }
        int totalMinute, totalCandiesInBowl, totalCandiesPlaceHolder, CandiesAdded;

        public int GetTotalExtraCandiesAdded(int totalCandies,int[]Candies,int totalMinute)
        {
            totalCandiesInBowl = totalCandies;
            this.totalMinute = totalMinute;
            totalCandiesPlaceHolder = totalCandiesInBowl;

            for (int i = 0; i < totalMinute-1; i++) 
            {
                totalCandiesInBowl -= Candies[i];
                if (totalCandiesInBowl < 5)
                {
                    CandiesAdded += totalCandiesPlaceHolder - totalCandiesInBowl;
                    totalCandiesInBowl = totalCandiesPlaceHolder;
                }
            }
            return CandiesAdded;
        }
    }
}
