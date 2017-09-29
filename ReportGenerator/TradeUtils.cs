using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReportGenerator
{
    class TradeUtils
    {
        public static bool isOptionTrade(Trade trade)
        {
            return (trade.putCall != "");
        }
        public static void sanatizeSymbol(Trade trade)
        {
            // Sanatize any numbers that might appear in the ticker name
            // Ex. SAN1 vs SAN
            // Name also occurs in full options contract name making repair harder
            if (isOptionTrade(trade))
            {
                string before = trade.symbol.Split(' ')[0];
                string after = Regex.Replace(before, "[0-9]", "");
                if (before != after)
                    trade.symbol = Regex.Replace(trade.symbol, before, after);
            }
        }
    }
}
