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
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("name")]
        public string PersianName { get; set; }
        [JsonProperty("name_en")]
        public string EnglishName { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
        [JsonProperty("dominance")]
        public double Dominance { get; set; }
        [JsonProperty("volume_24h")]
        public decimal Last24HoursTransactionsVolume { get; set; }
        [JsonProperty("market_cap")]
        public decimal MarketCap { get; set; }
        [JsonProperty("ath")]
        public decimal ATH { get; set; }
        [JsonProperty("ath_change_percentage")]
        public decimal ATHPercentChange { get; set; }
        [JsonProperty("ath_date")]
        public DateTime ATHDate { get; set; }
        [JsonProperty("price")]
        public decimal CurrentPrice { get; set; }
        [JsonProperty("daily_high_price")]
        public decimal DailyHighestPrice { get; set; }
        [JsonProperty("daily_low_price")]
        public decimal DailyLowestPrice { get; set; }
        [JsonProperty("weekly_high_price")]
        public decimal WeeklyHighestPrice { get; set; }
        [JsonProperty("weekly_low_price")]
        public decimal WeeklyLowestPrice { get; set; }
        [JsonProperty("percent_change_1h")]
        public double LastHourPercentChange { get; set; }
        [JsonProperty("percent_change_24h")]
        public double Last24HoursPercentChange { get; set; }
        [JsonProperty("percent_change_7d")]
        public double Last7DaysPercentChange { get; set; }
        [JsonProperty("percent_change_14d")]
        public double Last14DaysPercentChange { get; set; }
        [JsonProperty("percent_change_30d")]
        public double Last30DaysPercentChange { get; set; }
        [JsonProperty("percent_change_60d")]
        public double Last60DaysPercentChange { get; set; }
        [JsonProperty("percent_change_200d")]
        public double Last200DaysPercentChange { get; set; }
        [JsonProperty("percent_change_1y")]
        public double LastYearPercentChange { get; set; }
        [JsonProperty("price_change_24h")]
        public double Last24HoursPriceChange { get; set; }
        [JsonProperty("price_change_7d")]
        public double Last7DaysPriceChange { get; set; }
        [JsonProperty("price_change_14d")]
        public double Last14DaysPriceChange { get; set; }
        [JsonProperty("price_change_30d")]
        public double Last30DaysPriceChange { get; set; }
        [JsonProperty("price_change_60d")]
        public double Last60DaysPriceChange { get; set; }
        [JsonProperty("price_change_200d")]
        public double Last200DaysPriceChange { get; set; }
        [JsonProperty("price_change_1y")]
        public double LastYearPriceChange { get; set; }
        [JsonProperty("max_supply")]
        public double? MaxSupply { get; set; }
        [JsonProperty("total_supply")]
        public double? TotalSupply { get; set; }
        [JsonProperty("circulating_supply")]
        public double? CirculatingSupply { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatingDate { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatingDate { get; set; }
    }
}
