using System.Collections.Generic;
using System.Linq;

namespace RandomHackerRank
{
    public class BonAppetit
    {
        public static int ReturnExtraAmount(List<int> items,int notEatenItemIndex, int amountCharged)
        {
            items.RemoveAt(notEatenItemIndex);
            var totalSum = items.Aggregate((a, b) => a + b) / 2;
            return amountCharged <= totalSum ? 0 : amountCharged - totalSum;
        }
    }
}
