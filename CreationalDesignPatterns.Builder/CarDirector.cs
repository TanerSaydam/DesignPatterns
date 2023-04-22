using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder
{
    internal class CarDirector
    {
        public Car BuildSportCar()
        {
            return new CarBuilder()
                .SetColor("Kırmızı")
                .SetEnginePower(500)
                .SetInterior("Yün Döşeme")
                .Build();
        }

        public Car BuildFamilyCar()
        {
            return new CarBuilder()
                .SetColor("Mavi")
                .Build();
        }
    }
}
