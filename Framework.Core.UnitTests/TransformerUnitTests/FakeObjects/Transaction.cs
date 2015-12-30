using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.UnitTests.TransformerUnitTests.FakeObjects;

namespace Framework.Core.UnitTests.TransformerUnitTests.FakeObjects
{
    public class Transaction : RequestBase
    {
        public PanInfo PanInfo { get; set; }
        public string MSISDN { get; set; }
        public List<CustomData> CustomDataList { get; set; }
        public PaymentTransactionType PaymentTransactionType { get; set; }
        public int? TerminalNumberNullable { get; set; }
        public TerminalInfo TerminalInfo { get; set; }
    }
}
