using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHackerRank
{
    public class JesseRock
    {
        int totalRocks = Convert.ToInt32(Console.ReadLine());
        int jesseStrength = Convert.ToInt32(Console.ReadLine());
        public static void GetInputs(List<int> totalRocks, int JesseStrength)
        {
            int skipChances = 0;
            int brokenStone = 0;
            totalRocks.ForEach(a => 
            {
                if (JesseStrength >= a)
                {
                    if(skipChances <=1)
                    brokenStone++;
                }
                else
                {
                    skipChances++;
                }
            });
        }
    }
}
