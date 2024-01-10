using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    // Abstract class with the template method
    public abstract class HotBeverage
    {
        // The template method defines the overall algorithm
        public void PrepareBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        // Abstract methods to be implemented by subclasses
        protected abstract void Brew();
        protected abstract void AddCondiments();

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

    }
}
