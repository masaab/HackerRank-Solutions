using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppTester
{
    class Program
    {
        public async Task<string> TestME()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://creditorwatch.com.au/apiv_1_0_0/credit_score/id/e34efa3403c4f206c11404a6fbc37cd0/key/6c1da992/abn/73077778815");

            //will throw an exception if not successful
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
            string content = await response.Content.ReadAsStringAsync();
            return content;
            //await Task.Run(() => JsonObject.Parse(content));
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string data = p.TestME().Result;
        }
    }
}
