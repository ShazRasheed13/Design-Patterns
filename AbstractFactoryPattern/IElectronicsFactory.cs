using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // Abstract Factory interface
    public interface IElectronicFactory
    {
        ILaptop CreateLaptop();
        IsmartPhone CreateSmartPhone();
    }

    public class GamingElectronicsFactory : IElectronicFactory
    {
        public ILaptop CreateLaptop()
        {
            return new GamingLaptop();
        }

        public IsmartPhone CreateSmartPhone()
        {
            return new AndroidSmartPhone();
        }
    }

    public class BusinessElectronicsFactory : IElectronicFactory
    {
        public ILaptop CreateLaptop()
        {
            return new BusinessLaptop();
        }

        public IsmartPhone CreateSmartPhone()
        {
            return new Iphone();
        }
    }
}
