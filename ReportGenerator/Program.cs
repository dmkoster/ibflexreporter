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
            StringReader reader = new StringReader(File.ReadAllText(@"FlexStatementService.xml"));
            FlexQueryResponse response = (FlexQueryResponse)serializer.Deserialize(reader);

            // Parse Trades
            foreach(FlexQueryResponseFlexStatementsFlexStatementTrade trade in response.FlexStatements.FlexStatement.Trades)
            {
                //trade.
            }
        }
    }
}
