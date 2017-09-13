using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Day1.MainMethod();

            // Day4.MainMethod();

            // Day5.MainMethod();

            // Day6.MainMethod();

            // Day7.MainMethod();

        }
        public static int GetInputs(List<int> totalRocks, int JesseStrength)
        {
            int skipChances = 0;
            int brokenStone = 0;
            totalRocks.ForEach(a =>
            {
                if (JesseStrength >= a)
                {
                    if (skipChances <= 1)
                        brokenStone++;
                }
                else
                {
                    skipChances++;
                }
            });

            return brokenStone;
        }
    }
}
