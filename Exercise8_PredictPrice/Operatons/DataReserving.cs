using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_PredictPrice.Operatons
{
    class DataReserving
    {
        public static async Task<Tuple<double[], DateTime[]>> GetCryptoPrices(string cryptoKey)
        {
            double[] prices = new double[61];
            DateTime[] times = new DateTime[61];    
            for (int i = 0; i < 61; i++)
            {
                string content = await APIHandler.GetApiContent(cryptoKey);
                double price = (double)JsonHandler.JsonToObjectConverter(content);
                times[i] = DateTime.Now;
                prices[i] = price;
                if (i != 60)
                {
                    Console.WriteLine($"{i + 1}: " + price);
                    await Task.Delay(60000);
                }
            }
            return Tuple.Create(prices, times);
        }
        public static void SavePricesToCsv(double[] prices, DateTime[] times)
        {
            using StreamWriter streamWriter = new(@"E:\Csharp Projects\College\Prices.csv");
            for (int i = 0; i < prices.Length; i++)
            {
                streamWriter.WriteLine(prices[i].ToString("G29") + "," + times[i].ToString());
            }
        }
    }
}

