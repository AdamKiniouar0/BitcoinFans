using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitcoinFansWebAssembly.Data
{
    public class PublicTreasury
    {
        public float total_holdings { get; set; }
        public float total_value_usd { get; set; }
        public float market_cap_dominance { get; set; }
        public Company[] companies { get; set; }
    }

    public class Company
    {
        public string name { get; set; }
        public string symbol { get; set; }
        public string country { get; set; }
        public int total_holdings { get; set; }
        public long total_entry_value_usd { get; set; }
        public long total_current_value_usd { get; set; }
        public float percentage_of_total_supply { get; set; }
    }

}
