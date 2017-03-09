using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysChallenge
{
    public class Day1
    {
        public static DataTypeValue MainMethod()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackersRank ";

            int inputInteger = Convert.ToInt32(Console.ReadLine());
            double inputDouble = Convert.ToDouble(Console.ReadLine());
            string inputString =  Console.ReadLine();

            Console.WriteLine(i + inputInteger);
            Console.WriteLine(string.Format("{0:N1}", d + inputDouble));
            Console.WriteLine(s + inputString);
            return new DataTypeValue
            {
                InputInt = i + inputInteger,
                InputDouble =  d + inputDouble,
                InputString = s + inputString
            };
        }
    }

    public class DataTypeValue
    {
        public int InputInt { get; set; }
        public double InputDouble { get; set; }
        public string InputString { get; set; }
    }
}
