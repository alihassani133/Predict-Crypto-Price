//علی حسنی - Ali Hassani

using Exercise8_PredictPrice.Operatons;

string cryptoKey = "";
string filePath = @"E:\Csharp Projects\College\Prices.csv";


Console.WriteLine("Please choose which crypto do you want to get prices of it and predict its next price?");
Console.WriteLine("For Bitcoin press number 1,\n" +
                  "for Ethereum press number 2,\n" +
                  "for Dogecoin press number 3,\n" +
                  "for Litecoin press number 4,\n" +
                  "for Tethereum press number 5.");
string keyIndex = UserInterface.ControlUserInput();
switch (keyIndex)
{
    case "1":
        cryptoKey = "BTC";
        break;
    case "2":
        cryptoKey = "ETH";
        break;
    case "3":
        cryptoKey = "DOGE";
        break;
    case "4":
        cryptoKey = "LTC";
        break;
    case "5":
        cryptoKey = "USDT";
        break;
}
for (int i = 2; i < 11; i++)
{
    var data = await DataReserving.GetCryptoPrices(cryptoKey);
    DataReserving.SavePricesToCsv(data.Item1.Take(data.Item1.Length - 1).ToArray(), data.Item2.Take(data.Item1.Length - 1).ToArray());

    Console.WriteLine($"The actual next price: {(decimal)data.Item1[data.Item1.Length - 1]}\n");
    decimal nextPrice = Analysis.PredictByLineRegression(filePath);
    Console.WriteLine("prediction by line regression: " + nextPrice);
    var errorPercentage1 = Analysis.ErrorPercentage((decimal)data.Item1[data.Item1.Length - 1], nextPrice);
    Console.WriteLine($"the error percentage of this prediction algorithm: {errorPercentage1}%\n \n");


    decimal nextPrice2 = Analysis.PredictByMovingAverage(filePath);
    Console.WriteLine("prediction by moving average: " + nextPrice2);
    var errorPercentage2 = Analysis.ErrorPercentage((decimal)data.Item1[data.Item1.Length - 1], nextPrice2);
    Console.WriteLine($"the error percentage of this prediction algorithm: {errorPercentage2}%");

    string fileName = $"Screenshot{i}.png";
    ScreenShot.Capture(fileName);
    Thread.Sleep(4000);
    Console.Clear();
}



