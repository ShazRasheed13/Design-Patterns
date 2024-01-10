using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{

    public interface IsmartPhone
    {
        void Assemble();
    }

    public class AndroidSmartPhone : IsmartPhone
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling an Android smartphone.");
        }
    }

    public class Iphone : IsmartPhone
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling a iPhone.");
        }
    }
}

