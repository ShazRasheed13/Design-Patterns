using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // Target interface expected by the client
    public interface IModernPrinter
    {
        void Print(string message);
    }
}
