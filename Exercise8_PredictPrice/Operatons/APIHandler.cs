using Exercise8_PredictPrice.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_PredictPrice.Operatons
{
    class APIHandler
    {
        public static async Task<string> GetApiContent(string cryptoKey)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("X-API-Key", "4258|gbpz7Dfg8FIs1XTDaXVMOnLAoP1RzwCbzNA4urzE");
                var response = await httpClient.GetAsync("https://api.wallex.ir/v1/currencies/stats/?key=" + cryptoKey);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return content;
                }
                else
                {
                    throw new Exception(message: "Error retrieving data");
                }
            }
        }
    }
}
