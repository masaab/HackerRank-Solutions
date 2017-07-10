using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHackerRank
{
    public class AccurateSorting
    {
        List<int> items = new List<int>();
        public bool CanSort(int [] a)
        {
            for (int i = 0; i < a.Length - 1; i++) 
            {
                if (!CanSwap(a[i], a[1 + 1]))
                {
                    return false;
                }
                items.Add(a[i + 1]);
                items.Add(a[i]);
            }                                                                                                      
            return true;
        }
        public bool CanSwap(int x, int y)
        {
            return (x - y == 1) ? true : false;
        }
    }
}
