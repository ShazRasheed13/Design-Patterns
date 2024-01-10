using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class HomeTheaterFacade
    {
        private Lights lights;
        private Projector projector;
        private SoundSystem soundSystem;

        public HomeTheaterFacade()
        {
            lights = new Lights();
            projector = new Projector();
            soundSystem = new SoundSystem();
        }

        public void WatchMovie()
        {
            Console.WriteLine("Get ready to watch a movie!");
            lights.TurnOff();
            projector.TurnOn();
            soundSystem.TurnOn();
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down..."); 
            lights.TurnOn();
            projector.TurnOff();
            soundSystem.TurnOff();
        }
    }
}
