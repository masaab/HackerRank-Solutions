using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace _30DaysChallenge.Tests
{
    public class Challenge
    {
        [Fact]
        public void Day8Test()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            var data = File.ReadAllLines("1.txt");
            var totalTest = data[0];
            var list = data.ToList().Skip(1).Take(int.Parse(totalTest)).ToList();

            try
            {
                list.ForEach(a =>
                {
                    string[] pair = a.Split(' ');
                    keyValuePairs.Add(pair[0], pair[1]);
                });
            }
            catch (Exception e)
            {

            }

            var f = keyValuePairs;

            Day7.Day8(f);

            
        }
    }
}
