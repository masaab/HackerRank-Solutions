using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHackerRank
{
    public class ArraySum
    {
        public static int AddArrayElement(int[]items)
        {
            return items.Aggregate((a, b) => a + b);
        }
    }
}
