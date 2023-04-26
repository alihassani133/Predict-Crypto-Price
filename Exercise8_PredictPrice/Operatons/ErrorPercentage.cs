using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_PredictPrice.Operatons
{
    class ErrorPercentage
    {
        public static decimal PercentError(decimal actualPrice, decimal predictedPrice)
        {
            // calculate percent error
            decimal errorPercentage = Math.Abs(actualPrice - predictedPrice) / actualPrice * 100;
            return errorPercentage;
        }
    }
}
