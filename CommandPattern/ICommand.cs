using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // Command interface
    public interface ICommand
    {
        void Execute();
    }

    public class LightOnCommand(Light light) : ICommand
    {
        public void Execute()
        {
            light.TurnOn(); 
        }
    }

    public class StereoVolumeUpCommand(Stereo stereo) : ICommand
    {
        public void Execute()
        {
            stereo.VolumeUp();
        }
    }

}
