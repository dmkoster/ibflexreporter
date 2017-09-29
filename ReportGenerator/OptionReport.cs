using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    class OptionReport
    {
        Dictionary<String, OptionReportItem> contractItems;
        Dictionary<String, OptionReportItem> underlyingItems;

        public OptionReport(OptionTradeLog log)
        {
            contractItems = new Dictionary<string, OptionReportItem>();
            underlyingItems = new Dictionary<string, OptionReportItem>();

            foreach (OptionTradeLog.OptionTradeItem trade in log)
            {
                OptionReportItem contractItem;
                OptionReportItem underlyingItem;
                if (contractItems.ContainsKey(trade.contract))
                {
                    contractItem = contractItems[trade.contract];
                }
                else
                {
                    contractItem = new OptionReportItem();
                    contractItem.contractsOutstanding = 0;
                    contractItem.commision = 0;
                    contractItem.realized = 0;
                }

                contractItem.contractsOutstanding += trade.contractCount;
                contractItem.commision += trade.commision;
                contractItem.realized += trade.price * trade.contractCount * 100 * -1;

                contractItems[trade.contract] = contractItem;

                if(underlyingItems.ContainsKey(trade.symbol))
                {
                    underlyingItem = underlyingItems[trade.symbol];
                    underlyingItem.contractsOutstanding += trade.contractCount;
                    underlyingItem.commision += trade.commision;
                    underlyingItem.realized += trade.price * trade.contractCount * 100 * -1;
                }
                else
                {
                    underlyingItem = contractItem;
                }
                underlyingItems[trade.symbol] = underlyingItem;
            }
        }

        struct OptionReportItem
        {
            public int contractsOutstanding { get; set; }
            public decimal commision { get; set; }
            public decimal realized { get; set; }

            public override string ToString()
            {
                char seperator = ',';
                StringBuilder builder = new StringBuilder();

                builder.Append(contractsOutstanding);
                builder.Append(seperator);
                builder.Append(commision);
                builder.Append(seperator);
                builder.Append(realized);                

                return builder.ToString();
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (KeyValuePair<String, OptionReportItem> item in contractItems)
            {
                builder.AppendLine(item.Key.ToString() + "," + item.Value.ToString());
            }
            builder.AppendLine();
            foreach (KeyValuePair<String, OptionReportItem> item in underlyingItems)
            {
                builder.AppendLine(item.Key.ToString() + "," + item.Value.ToString());
            }
            return builder.ToString();
        }
    }
}
