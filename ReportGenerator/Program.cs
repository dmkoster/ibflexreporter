using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ReportGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            String flexFileDirectory = @"C:\Users\David\Source\Repos\ibflexreporter\";
            String[] files = Directory.GetFiles(flexFileDirectory, "*.xml");

            List<Trade> allTrades = new List<Trade>();
            foreach(String file in files)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(FlexQueryResponse));
                StringReader reader = new StringReader(File.ReadAllText(file));
                FlexQueryResponse response = (FlexQueryResponse)serializer.Deserialize(reader);
                allTrades.AddRange(response.FlexStatements.FlexStatement.Trades);
            }

            foreach(Trade trade in allTrades)
            {
                TradeUtils.sanatizeSymbol(trade);
            }

            Console.WriteLine("Commision By Symbol");
            TradeTracker t = new TradeTracker(allTrades.ToArray());
            foreach (string symbol in t.getSymbols())
            {
                Console.WriteLine(symbol + " " + t.getCommisionBySymbol(symbol));
            }
            foreach (string symbol in t.getOptionSymbols())
            {
                Console.WriteLine("Option " + symbol + " " + t.getCommisionByOptionSymbol(symbol));
            }

            Console.WriteLine("Stock Trade Log");
            StockTradeLog log = new StockTradeLog(allTrades.ToArray());
            Console.WriteLine(log.ToString());

            Console.WriteLine("Stock Position Report");

            Console.WriteLine("Option Trade Log");
            OptionTradeLog optLog = new OptionTradeLog(allTrades.ToArray());
            Console.WriteLine(optLog.ToString());

            Console.WriteLine("Option Position Report");
            OptionReport optReport = new OptionReport(optLog);
            Console.WriteLine(optReport.ToString());
        }
    }
}
