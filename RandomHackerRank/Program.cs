using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gemstones gm = new Gemstones();
            //gm.GetInputs();
            //LeaderBoard lb = new LeaderBoard();
            //lb.GetInputs();
            // DrawingBook book = new DrawingBook();
            // book.GetInputs();
            // ArrayDS.Result();
            ReplenishBowl test = new ReplenishBowl();
            Console.WriteLine(test.GetTotalCandies());
        }
    }
}
