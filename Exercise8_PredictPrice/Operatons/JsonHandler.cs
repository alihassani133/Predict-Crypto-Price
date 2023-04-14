using Exercise8_PredictPrice.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_PredictPrice.Operatons
{
    class JsonHandler
    {
        public static decimal JsonToObjectConverter(string content)
        {
            CryptoData data = JsonConvert.DeserializeObject<APIProperties>(content).Result[0];
            return data.CurrentPrice;
        }
    }
}
