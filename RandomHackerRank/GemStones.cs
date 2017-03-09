using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHackerRank
{
    public class Gemstones
    {
        public Gemstones()
        {

        }

        public void GetInputs()
        {
           
           // var data = value.Replace("\r\n", "");
          //  var inputs = data.Split(',');
            var totalRocks = Convert.ToInt32(Console.ReadLine());

            int counter = 0;
            int SameElementCounter = 0;
            string[] stoneElements = new string[totalRocks];
            for (int i = 0; i < totalRocks; i++)
            {
                stoneElements[i] = Console.ReadLine();
            }
            stoneElements = stoneElements.OrderBy(a => a.Length).ToArray();
            var firstElement = stoneElements[0].Distinct().ToArray();
            for (int i = 0; i < firstElement.Length; i++)
            {
                string firstStoneElement = firstElement[i].ToString();
                for (int j = 1; j < stoneElements.Length; j++)
                {
                    if (stoneElements[j].Contains(firstStoneElement))
                    {
                        SameElementCounter++;
                    }
                    else
                    {
                        SameElementCounter=0;
                    }
                }
                if (SameElementCounter >= stoneElements.Length-1)
                {
                    counter++;
                    SameElementCounter = 0;
                }
            }
            Console.WriteLine(counter.ToString());

        }
    }
}
