using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Sport_Car : Car
    {
        public Sport_Car()
        {
            AverageFuelConsumption = 15.6;
            FuelTank = 37;
            Speed = 180;
        }
        public void Start()
        {
            Console.Clear();
            SensorEmpty();
            Console.WriteLine("Сейчас поедем дрифтовать!");
        }
    }

}
