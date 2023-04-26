using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_PredictPrice.Operatons
{
    class SavingToFile
    {
        readonly string _filePath;
        public SavingToFile(string filepath)
        {
            _filePath = filepath;
        }

        public void SavePricesToCsv(double[] prices, DateTime[] times)
        {
            using StreamWriter streamWriter = new(_filePath);
            for (int i = 0; i < prices.Length; i++)
            {
                streamWriter.WriteLine(prices[i].ToString("G29") + "," + times[i].ToString());
            }
        }
    }
}
