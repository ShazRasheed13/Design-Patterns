using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface ILaptop
    {
        void Assemble();
    }

    public class GamingLaptop : ILaptop
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling a gaming laptop.");
        }
    }

    public class BusinessLaptop : ILaptop
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling a business laptop.");
        }
    }

}
