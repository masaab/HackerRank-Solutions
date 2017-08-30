using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHackerRank
{
    public class SockMerchant
    {
        public static int GetSockPair(int [] socksArray)
        {
            int[] socks = socksArray;
            var items = socks.GroupBy(a => a);
            int counter = 0;
            int finalValue = 0;
            foreach (var item in items)
            {
                if (item.Count() > 1)
                {
                    finalValue = item.Count();
                    if (IsOdd(item.Count()))
                    {
                        finalValue = item.Count() - 1;
                    }
                    counter += finalValue / 2;
                }
            }
            return counter;
        }

        private static bool IsOdd(int number)
        {
            return (number % 2 != 0) ? true : false;
        }
    }
}
