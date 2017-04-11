using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHackerRank
{
    public class BeautifulWord
    {
        string[] vowels = { "a", "e", "i", "0", "u", "y" };
        public bool CheckCorrectString(string data)
        {
            if (data.Length == 1)
            {
                return true;
            }

            for (int i = 0; i < data.Length - 1; i++)
            {
                if (data[i] == data[i + 1])
                {
                    return false;
                }
                if (vowels.Contains(data[i].ToString()) && vowels.Contains(data[i + 1].ToString()))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
