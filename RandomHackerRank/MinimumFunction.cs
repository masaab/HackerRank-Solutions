namespace RandomHackerRank
{
    public class MinimumFunction
    {
        string Default = "min(int, int)";
        string minStruct = "min(int, ";
        int input = 4;
        public string TotalMinimumFunctionCall()
        {
            string minString = "";
            for (int i = 2; i < input; i++)
            {
                minString += minStruct;
            }
            minString += Default;

            var total = input - 2;
            var counter = 0;
            while (counter < total)
            {
                minString += ")";
                counter++;
            }
            
            return minString;
        }
    }
}
