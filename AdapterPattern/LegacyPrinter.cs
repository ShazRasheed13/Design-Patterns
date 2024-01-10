using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class LegacyPrinter
    {
        // Adaptee class with the desired behavior
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
