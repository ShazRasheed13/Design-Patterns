using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }

    // Concrete Component representing a basic coffee
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Simple Coffee";
        }

        public double GetCost()
        {
            return 1;
        }
    }
}
