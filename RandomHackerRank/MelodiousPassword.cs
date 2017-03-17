using System.Collections;
using System.Linq;

namespace RandomHackerRank
{
    public class MelodiousPassword
    {
        int inputRange = 5;
        ArrayList passwordList = new ArrayList();

        private bool CheckIfYExists(string password)
        {
            return password.Contains("y") ? true : false;
        }

        public bool CheckIsMelodiousPassword(string password)
        {
            bool? currentValue = null;
            bool? previousValue = null;
            for (int i = 0; i < password.Length; i++)
            {
                currentValue = CheckValidValues(password[i].ToString());

                if (currentValue != previousValue)
                {
                    previousValue = currentValue;
                }
                else { return false; }
            }
            return true;
        }

        public void CreatePair(string password)
        {
            string[][] list = new string[password.Length][];
            if (password.Length % 2 == 0)
            {
                for (int i = 0, j = 0; i < password.Length && j < password.Length; i++, j += 2) 
                {
                    list[i] = new string[] {password[j].ToString(), password[j+1].ToString() };
                }
            }
            else
            {

            }
            SwapPairs(list);
        }

        public void SwapPairs(string[][] data)
        {
            string passwordNew = "";
            string[][] temp = new string[1][];
            var content = data.Where(a => a != null);
            var totalLoops = content.Count() * 2;
            var currentRow = 0;
            for (int i = 0; i < totalLoops; i++)
            {
                for (int row = 0; row < content.Count(); row++)
                {
                    passwordNew += data[row][0] + data[row][1];
                    
                }
                passwordList.Add(passwordNew);
                passwordNew = string.Empty;
                if (currentRow < (content.Count()-2))
                {
                    temp[0] = data[currentRow + 1];
                    data[currentRow + 1] = data[currentRow + 2];
                    data[currentRow + 2] = temp[0];
                    currentRow++;
                }
                else
                {
                    currentRow = 0;
                    temp[0] = data[0];
                    data[0] = data[0 + 1];
                    data[1] = temp[0];
                }
            }
        }

        private bool CheckValidValues(string a)
        {
            return  CheckIsVowel(a);
        }
        private bool CheckIsVowel(string word)
        {
            string vowelString = "aeiou";
            return vowelString.Contains(word) ? true : false;
        }

        public void GetInput(int passwordLenght)
        {

        }
    }
}
