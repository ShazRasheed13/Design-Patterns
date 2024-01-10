using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class LegacyPrinterAdapter:IModernPrinter
    {
        private LegacyPrinter _legacyPrinter;
        public LegacyPrinterAdapter(LegacyPrinter legacyPrinter)
        {
            _legacyPrinter = legacyPrinter;
        }
        public void Print(string message)
        {
            _legacyPrinter.PrintMessage(message);
        }
    }
}
