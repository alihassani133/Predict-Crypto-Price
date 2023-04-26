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
        public static async Task<Tuple<double[], DateTime[]>> ReserveCryptoData(string cryptoKey)
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
                    await Task.Delay(1000);
                }
            }
            return Tuple.Create(prices, times);
        }
    }
}

