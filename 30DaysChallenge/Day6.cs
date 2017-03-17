using System;
using System.Collections.Generic;

namespace _30DaysChallenge
{
    public class Day6
    {
        public static void MainMethod()
        {
            int count = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                list.Add(word);
            }
            foreach (var item in list)
            {
                string result = GetEvenOddCharacterIndex(item);
                Console.WriteLine(result);
            }
        }

        private static string GetEvenOddCharacterIndex(string word)
        {
            char[] words = word.ToCharArray();
            string evenCharcters = string.Empty, oddCharacters = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenCharcters += words[i];
                }
                else
                {
                    oddCharacters += words[i];
                }
            }
            return $"{ evenCharcters} {oddCharacters}";
        }
    }
}
