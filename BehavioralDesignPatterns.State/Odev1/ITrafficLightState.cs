using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.State.Odev1
{
    public interface ITrafficLightState
    {
        void Change(TrafficLight trafficLight);
    }

    public class TrafficLight
    {
        private ITrafficLightState _state;

        public TrafficLight(ITrafficLightState state)
        {
            _state = state;
        }

        public void SetState(ITrafficLightState state)
        {
            _state = state;
        }

        public void Change()
        {
            _state.Change(this);
        }
    }

    public class RedState : ITrafficLightState
    {
        void ITrafficLightState.Change(TrafficLight trafficLight)
        {
            Console.WriteLine("Kırmızı ışık: Dur!");
            trafficLight.SetState(new GreenState());
        }
    }

    public class GreenState : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            Console.WriteLine("Yeşil ışık: Geç!");
            trafficLight.SetState(new YellowState());
        }
    }

    public class YellowState : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            Console.WriteLine("Sarı ışık: Bekle!");
            trafficLight.SetState(new RedState());
        }
    }
}

