using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    // Abstract builder interface
    public interface IComputerBuilder
    {
        void SetProcessor();
        void SetRAM();
        void SetStorage();
        void SetGraphicsCard();
        Computer GetComputer();
    }
}
