using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_PredictPrice.Models
{
    class CryptoData
    {
        [JsonProperty("name_en")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public decimal CurrentPrice { get; set; }
    }
}
