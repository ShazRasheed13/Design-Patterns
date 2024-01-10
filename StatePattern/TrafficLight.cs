using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    // Context class (Traffic Light)
    public class TrafficLight
    {
        private TrafficLightState currentState;

        public TrafficLight()
        {
            currentState = new RedLightState(this);
        }

        public void ChangeState(TrafficLightState state)
        {
            currentState = state;
        }

        public void Request()
        {
            currentState.Handle();
        }
    }
}
