using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_PredictPrice.Models
{
    class APIProperties
    {
        public List<CryptoData> Result { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public string Provider { get; set; }
    }
}
