using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitcoinFansWebAssembly.Models
{
    public class PriceObject
    {
        public Bitcoin bitcoin { get; set; }
        public Vechain vechain { get; set; }
        public Ethereum ethereum { get; set; }
    }

    public class Bitcoin
    {
        public int sek { get; set; }
        public int usd { get; set; }
    }

    public class Vechain
    {
        public float sek { get; set; }
        public float usd { get; set; }
    }

    public class Ethereum
    {
        public int sek { get; set; }
        public float usd { get; set; }
    }
}

