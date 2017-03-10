using System;

namespace RandomHackerRank
{
    public class _2DArray
    {
        private int[][] arr { get; set; }
        private int? largestSum = null;
        public _2DArray()
        {
            arr = new int[6][];
            //arr[0] = new int[] { 1, 1, 1, 0, 0, 0 };
            //arr[1] = new int[] { 0 ,1, 0 ,0 ,0 ,0 };
            //arr[2] = new int[] { 1 ,1 ,1, 0, 0 ,0 };
            //arr[3] = new int[] { 0, 0, 2 ,4 ,4 ,0 };
            //arr[4] = new int[] { 0, 0, 0, 2, 0, 0 };
            //arr[5] = new int[] { 0, 0, 1, 2, 4, 0 };

            arr[0] = new int[] { -1, -1, 0, -9, -2, -2 };
            arr[1] = new int[] { -2, -1, -6, -8, -2, -5 };
            arr[2] = new int[] { -1, -1, - 1, -2, -3, -4 };
            arr[3] = new int[] { -1, -9, -2, -4, -4, -5 };
            arr[4] = new int[] { -7, -3, -3, -2, -9, -9 };
            arr[5] = new int[] { -1, -3, -1, -2, -4, -5 };
        }




        public int? GetLargestGlassHourSum()
        {

            //for (int arr_i = 0; arr_i < 6; arr_i++)
            //{
            //    string[] arr_temp = Console.ReadLine().Split(' ');
            //    arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            //}
            for (var row = 0; arr.Length > row ; row++)
            {
                if ((arr.Length - row) < 3)
                    break;
                for (var col = 0; col <= arr[row].Length; col++)
                {
                    if ((arr[row].Length - col) < 3)
                        break;
                    CreateGlassHour(row, col);            
                }
            }
            Console.WriteLine(largestSum);
            return largestSum;
        } 
        private void CreateGlassHour(int row, int col)
        {
                int line1 = arr[row][col] + arr[row][col + 1] + arr[row][col + 2];
                int line2 = arr[row + 1][col + 1];
                int line3 = arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2];
                int total = line1 + line2 + line3;
                largestSum =(total > largestSum || largestSum == null) ? total : largestSum;
        }
    }
}
