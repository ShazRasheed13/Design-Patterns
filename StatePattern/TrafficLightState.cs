using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    // State interface
    public interface TrafficLightState
    {
        void Handle();
    }

    // Concrete state classes
    public class RedLightState : TrafficLightState
    {
        private readonly TrafficLight trafficLight;

        public RedLightState(TrafficLight trafficLight)
        {
            this.trafficLight = trafficLight;
        }
        public void Handle()
        {
            Console.WriteLine("Traffic Light is RED. Stop!");
            trafficLight.ChangeState(new GreenLightState(trafficLight));
        }
    }

    public class GreenLightState : TrafficLightState
    {
        private readonly TrafficLight trafficLight;

        public GreenLightState(TrafficLight trafficLight)
        {
            this.trafficLight = trafficLight;
        }

        public void Handle()
        {
            Console.WriteLine("Traffic Light is GREEN. Go!");
            trafficLight.ChangeState(new YellowLightState(trafficLight));
        }
    }

    public class YellowLightState : TrafficLightState
    {
        private readonly TrafficLight trafficLight;

        public YellowLightState(TrafficLight trafficLight)
        {
            this.trafficLight = trafficLight;
        }

        public void Handle()
        {
            Console.WriteLine("Traffic Light is YELLOW. Prepare to stop!");
            trafficLight.ChangeState(new RedLightState(trafficLight));
        }
    }
}
