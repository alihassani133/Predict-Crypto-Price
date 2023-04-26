using MathNet.Numerics.LinearRegression;
using System.Reflection.Metadata;

namespace Exercise8_PredictPrice.Operatons
{
    class Analysis
    {
        readonly string _filePath;
        public Analysis(string filepath)
        {
            _filePath = filepath;
        }

        //predict price using moving average algorithm
        public decimal PredictByMovingAverage()
        {
            var data = File.ReadAllLines(_filePath)
                           .Select(x =>
                           {
                               var values = x.Split(',');
                               return new
                               {
                                   Price = double.Parse(values[0]),
                                   Time = DateTime.Parse(values[1])
                               };
                           })
                           .ToArray();
            double[] prices = data.Select(x => x.Price).ToArray();
            int windowSize = 60;
            if (prices.Length < windowSize)
            {
                throw new ArgumentException("Not enough prices to calculate Moving Average.");
            }
            // Compute the Moving Average of the last 100 prices.
            decimal movingAverage = (decimal)prices.Skip(prices.Length - windowSize)
                                          .Average();
            // Predict the next price by using the Moving Average as the prediction.
            decimal nextPrice = movingAverage;

            return nextPrice;
        }
        //predict price using moving line regression algorithm
        public decimal PredictByLineRegression()
        {
            var data = File.ReadAllLines(_filePath)
                           .Select(x =>
                           {
                               var values = x.Split(',');
                               return new
                               {
                                   Price = double.Parse(values[0]),
                                   Time = DateTime.Parse(values[1])
                               };
                           })
                           .ToArray();
            double[] prices = data.Select(x => x.Price).ToArray();
            DateTime[] times = data.Select(x => x.Time).ToArray();

            // Initialize the start time and minute value for the first price
            var startTime = times[0];
            var minute = 0;

            // Create arrays to store the minute and price values
            var minutes = new double[times.Length];

            for (int i = 0; i < times.Length; i++)
            {
                // Calculate the elapsed time since the start time
                var elapsedTime = times[i] - startTime;

                // Calculate the minute value based on the elapsed time (rounded down to the nearest integer)
                minute = (int)elapsedTime.TotalMinutes;

                // Store the minute and price values in the arrays
                minutes[i] = minute;
            }

            // Calculate the linear regression parameters (slope and intercept)
            var regression = SimpleRegression.Fit(minutes, prices);
            var slope = regression.ToTuple().Item2;
            var intercept = regression.ToTuple().Item1;

            // Predict the price at the 101th minute
            var predictedPrice = (decimal)(slope * (minute + 1) + intercept);

            return predictedPrice;
        }
    }

}
