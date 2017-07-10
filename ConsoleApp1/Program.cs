using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class TestHttpGet
    {
        public async void TestME()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://creditorwatch.com.au/apiv_1_0_0/credit_score/id/e34efa3403c4f206c11404a6fbc37cd0/key/6c1da992/abn/73077778815");

            //will throw an exception if not successful
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            //await Task.Run(() => JsonObject.Parse(content));
        }
    }

    public class AccurateSorting
    {

        List<int> items = new List<int>();
        public void CanSort(int[] a)
        {
            items.Clear();
            for (int i = 0; i < a.Length-1 ; i++)
            {
                if (CanSwap(a[i], a[i + 1]))
                {
                    items.Add(a[i + 1]);
                    items.Add(a[i]);
                }
            }
            CheckAscending(items);
        }
        private bool CanSwap(int x, int y)
        {
            if (x < y) return false;
            return (x - y == 1) ? true : false;
        }

        private bool CheckAscending(List<int> data)
        {
            for (int i = 0; i < data.Count-1; i++)
            {
                if ((data[i+1]) < data[i])
                {
                   //Console.WriteLine("No");
                    return false;
                }
            }
            return true;
            //Console.WriteLine("Yes");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // AccurateSorting ss = new AccurateSorting();
           // ss.CanSort(new int[] { 1, 0, 3, 2, 5, 4, 7, 6, 9, 8 });
            //ss.CanSort(new int[] { 2, 1, 0 });
            // foreach (string item in ss.answerlist)
            // {
            //     Console.WriteLine(item);
            // }

            int q = Convert.ToInt32(Console.ReadLine());
            List<int[]> allarray = new List<int[]>();
            for (int a0 = 0; a0 < q; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                allarray.Add(a);
            }
            for (int i = 0; i < allarray.Count; i++)
            {
                AccurateSorting ss = new AccurateSorting();
                 ss.CanSort(allarray[i]);
            }
        }
    }
}
