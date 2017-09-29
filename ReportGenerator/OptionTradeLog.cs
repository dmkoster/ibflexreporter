using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReportGenerator
{
    class OptionTradeLog : IEnumerable
    {
        static Regex contractRegex = new Regex(@"(\w+?)\s+?\d{6}(\w)\d+");

        List<OptionTradeItem> items;

        public OptionTradeLog(Trade[] trades)
        {
            items = new List<OptionTradeItem>();
            foreach (Trade trade in trades)
            {
                if (trade.putCall != "")
                {
                    String time = trade.tradeDate.ToString();
                    DateTime dtTime = new DateTime(int.Parse(time.Substring(0, 4)), int.Parse(time.Substring(4, 2)), int.Parse(time.Substring(6, 2)));
                    items.Add(new OptionTradeItem(trade.symbol, dtTime, trade.quantity, trade.tradePrice, trade.ibCommission));
                }
            }
        }

        public struct OptionTradeItem
        {
            public String symbol { get; }
            public String contract { get; }
            public String type { get; }
            public DateTime date { get; }
            public int contractCount { get; }
            public decimal price { get; }
            public decimal commision { get; }

            public OptionTradeItem(String contract, DateTime date, int contractCount, decimal price, decimal commision)
            {
                this.contract = contract;
                this.date = date;
                this.contractCount = contractCount;
                this.price = price;
                this.commision = commision;

                Match match = contractRegex.Match(contract);
                symbol = match.Groups[1].Value;
                type = match.Groups[2].Value;
            }

            public override string ToString()
            {
                char seperator = ',';
                StringBuilder builder = new StringBuilder();

                builder.Append(symbol);
                builder.Append(seperator);

                builder.Append(type);
                builder.Append(seperator);

                builder.Append(contract);
                builder.Append(seperator);

                builder.Append(date.ToShortDateString());
                builder.Append(seperator);

                builder.Append(contractCount);
                builder.Append(seperator);

                builder.Append(price);
                builder.Append(seperator);

                builder.Append(commision);
                builder.Append(seperator);

                return builder.ToString();
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (OptionTradeItem item in items)
            {
                builder.AppendLine(item.ToString());
            }
            return builder.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)items).GetEnumerator();
        }
    }
}
