using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Client
    {
        public void PrintMessage(IModernPrinter modernPrinter, string message)
        {
            modernPrinter.Print(message);
        }
    }
}
