using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is on");
        }
    }

    public class Stereo
    {
        public void VolumeUp()
        {
            Console.WriteLine("Volume is up");
        }
    }
}
