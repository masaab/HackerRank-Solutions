using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace _30DaysChallenge
{
    public static class ChallengeDay
    {
        public static void Day7()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            var total = (n - 1) + (m - 1);
            Console.WriteLine(total);
            Console.ReadLine();
        }

        public static void Day8(Dictionary<string, string> valuePair)
        {
            Dictionary<string, string> valuePairs = valuePair;
            List<string> dataList = new List<string>();
            string line;
            StreamReader file = new StreamReader("2.txt");
            while ((line = file.ReadLine()) != null)
            {
                string localValue;
                if (valuePairs.TryGetValue(line, out localValue))
                {
                    dataList.Add($"{line}={localValue}");
                }
                else
                {
                    dataList.Add("Not found");
                }
            }

            dataList.ForEach(Console.WriteLine);
            File.WriteAllLines("3.txt", dataList);
        }

        public static long Day9(int n)
        {
            var data = RecurseME(1);
           result = FindFactorial(n);
            return result;
        }

        private static int RecurseME(int value)
        {
            if (value >= 5)
                return 1;
            return 2 * RecurseME(value+1);

        }

        public static long result;

        private static long FindFactorial(int inputNumber)
        {
            if (inputNumber == 1)
                return 1;
           return inputNumber* FindFactorial(inputNumber - 1);
        }



        
    }
}
