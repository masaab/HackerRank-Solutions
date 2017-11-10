using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHackerRank
{
    public class StrongPassword
    {
        
        string numbers = "0123456789";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string special_characters = "!@#$%^&*()-+";
        public int GetResult(string value)
        {
            var data = ValidateStringLenght(value);
            if (data != 0)
            {
                return data;
            }
            var items = value.ToList();
            var v1 = Convert.ToInt32(ContainNumber(items));
            var v2 = Convert.ToInt32(ContainUpperCase(items));
            var v3 = Convert.ToInt32(ContainLowerCase(items));
            var v4 = Convert.ToInt32(ContainSpecialCharacter(items));
            return 4 - (v1 + v2 + v3 + v4);
        }
        private int ValidateStringLenght(string value)
        {
            if (value.Length < 6)
            {
                return 6 - value.Length;
            }
            return 0;
        }
        private bool ContainNumber(List<char> items)
        {
            foreach (var item in items)
            {
                if (numbers.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainUpperCase(List<char> items)
        {

            foreach (var item in items)
            {
                if (upper_case.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainLowerCase(List<char> items)
        {
            foreach (var item in items)
            {
                if (lower_case.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainSpecialCharacter(List<char> items)
        {
            foreach (var item in items)
            {
                if (special_characters.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

