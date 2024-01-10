using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    // Concrete builder for a Gaming Computer
    public class GamingComputerBuilder: IComputerBuilder
    {
        private Computer _computer = new Computer();
        public void SetProcessor()
        {
            _computer.Processor = "Intel Core i7-7700K";
        }

        public void SetRAM()
        {
            _computer.RAM = 32;
        }

        public void SetStorage()
        {
            _computer.Storage = 1000;
        }

        public void SetGraphicsCard()
        {
            _computer.GraphicsCard = "Nvidia GeForce GTX 1080 Ti";
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }
}
