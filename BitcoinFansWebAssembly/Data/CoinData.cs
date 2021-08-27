using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitcoinFansWebAssembly.Data
{

    public class CoinData
    {
        public string id { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public float current_price { get; set; }
        public long market_cap { get; set; }
        public int market_cap_rank { get; set; }
        public object fully_diluted_valuation { get; set; }
        public int total_volume { get; set; }
        public float high_24h { get; set; }
        public float low_24h { get; set; }
        public float price_change_24h { get; set; }
        public float price_change_percentage_24h { get; set; }
        public float market_cap_change_24h { get; set; }
        public float market_cap_change_percentage_24h { get; set; }
        public long circulating_supply { get; set; }
        public long total_supply { get; set; }
        public object max_supply { get; set; }
        public float ath { get; set; }
        public float ath_change_percentage { get; set; }
        public DateTime ath_date { get; set; }
        public float atl { get; set; }
        public float atl_change_percentage { get; set; }
        public DateTime atl_date { get; set; }
        public Roi roi { get; set; }
        public DateTime last_updated { get; set; }
    }

    public class Roi
    {
        public float times { get; set; }
        public string currency { get; set; }
        public float percentage { get; set; }
    }

}
