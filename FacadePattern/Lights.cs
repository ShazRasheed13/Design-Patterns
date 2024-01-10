using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Lights
    {
        public void TurnOn()
        {
            Console.WriteLine("Lights are on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Lights are off.");
        }
    }

    public class Projector
    {
        public void TurnOn()
        {
            Console.WriteLine("Projector are on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Projector are off.");
        }
    }

    public class SoundSystem
    {
        public void TurnOn()
        {
            Console.WriteLine("SoundSystem are on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("SoundSystem are off.");
        }
    }
}
