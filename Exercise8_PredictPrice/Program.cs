//علی حسنی - Ali Hassani

using Exercise8_PredictPrice.Operatons;

string cryptoKey = "";
string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "Prices.csv";

Analysis analysis = new(filepath);
SavingToFile savingToFile = new(filepath);
ScreenShot screenShot = new(filepath);

Console.WriteLine("Please choose which crypto do you want to get prices of it and predict its next price?");
Console.WriteLine("For Bitcoin press number 1,\n" +
                  "for Ethereum press number 2,\n" +
                  "for Dogecoin press number 3,\n" +
                  "for Litecoin press number 4,\n" +
                  "for Tethereum press number 5.");
string keyIndex = LockKeyboard.ControlUserInput();
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
    var data = await DataReserving.ReserveCryptoData(cryptoKey);
    savingToFile.SavePricesToCsv(data.Item1.Take(data.Item1.Length - 1).ToArray(), data.Item2.Take(data.Item1.Length - 1).ToArray());

    Console.WriteLine($"The actual next price: {(decimal)data.Item1[^1]}\n");
    decimal nextPrice = analysis.PredictByLineRegression();
    Console.WriteLine("prediction by line regression: " + nextPrice);
    var errorPercentage1 = ErrorPercentage.PercentError((decimal)data.Item1[^1], nextPrice);
    Console.WriteLine($"the error percentage of this prediction algorithm: {errorPercentage1}%\n \n");


    decimal nextPrice2 = analysis.PredictByMovingAverage();
    Console.WriteLine("prediction by moving average: " + nextPrice2);
    var errorPercentage2 = ErrorPercentage.PercentError((decimal)data.Item1[^1], nextPrice2);
    Console.WriteLine($"the error percentage of this prediction algorithm: {errorPercentage2}%");

    string filename = $"Screenshot{i}.png";
    screenShot.Capture(filename);
    Thread.Sleep(3000);
}



