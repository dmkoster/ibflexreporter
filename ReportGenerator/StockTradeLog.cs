using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    class StockTradeLog
    {
        List<StockTradeItem> items;

        public StockTradeLog(FlexQueryResponseFlexStatementsFlexStatementTrade[] trades)
        {
            items = new List<StockTradeItem>();
            foreach(FlexQueryResponseFlexStatementsFlexStatementTrade trade in trades)
            {
                if(trade.putCall == "")
                {
                    String time = trade.tradeDate.ToString();
                    DateTime dtTime = new DateTime(int.Parse(time.Substring(0, 4)), int.Parse(time.Substring(4, 2)), int.Parse(time.Substring(6,2)));
                    items.Add(new StockTradeItem(trade.symbol, dtTime, trade.quantity, trade.tradePrice, trade.ibCommission));
                }
            }
        }

        struct StockTradeItem
        {
            String symbol { get; }
            DateTime date { get; }
            int shareCount { get; }
            decimal price { get; }
            decimal commision { get; }

            public StockTradeItem(String symbol, DateTime date, int shareCount, decimal price, decimal commision)
            {
                this.symbol = symbol;
                this.date = date;
                this.shareCount = shareCount;
                this.price = price;
                this.commision = commision;
            }

            public override string ToString()
            {
                char seperator = ',';
                StringBuilder builder = new StringBuilder();

                builder.Append(symbol);
                builder.Append(seperator);

                builder.Append(date.ToShortDateString());
                builder.Append(seperator);

                builder.Append(shareCount);
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
            foreach(StockTradeItem item in items)
            {
                builder.AppendLine(item.ToString());
            }
            return builder.ToString();
        }
    }
}
