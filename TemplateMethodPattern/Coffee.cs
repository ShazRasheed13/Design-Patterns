using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    // Concrete subclass - Coffee
    public class Coffee : HotBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing coffee grounds");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}
