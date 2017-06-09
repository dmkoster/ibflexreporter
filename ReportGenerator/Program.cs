using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ReportGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(FlexQueryResponse));
            StringReader reader = new StringReader(File.ReadAllText(@"C:\Users\David\Source\Repos\ibflexreporter\FlexStatementService.xml"));
            FlexQueryResponse response = (FlexQueryResponse)serializer.Deserialize(reader);

            TradeTracker t = new TradeTracker(response.FlexStatements.FlexStatement.Trades);
            foreach (string symbol in t.getSymbols())
            {
                Console.WriteLine(symbol + " " + t.getCommisionBySymbol(symbol));
            }
            foreach (string symbol in t.getOptionSymbols())
            {
                Console.WriteLine("Option " + symbol + " " + t.getCommisionByOptionSymbol(symbol));
            }

            StockTradeLog log = new StockTradeLog(response.FlexStatements.FlexStatement.Trades);
            Console.WriteLine(log.ToString());
        }
    }
}
