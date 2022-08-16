using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Truck_Car : Car
    {
        public Truck_Car()
        {
            AverageFuelConsumption = 21.8;
            FuelTank = 18;
            Speed = 50;
        }
        public int Cargo { get; set; }
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Сколько кило груза повезем сегодня?");
            Cargo = int.Parse(Console.ReadLine());
            if (Cargo >= 1 & Cargo <= 1000)
            {
                Console.Clear();
                
                Console.WriteLine("Отлчично, можем ехать!");
                SensorWithCargo(Cargo);

            }
            else if (Cargo == 0)
            {
                Console.WriteLine("Сегодня на легке!");
                SensorEmpty();
            }
            else
            {
                Console.WriteLine("Куда столько взял, ты видел моё гнилое днище? Давай разгружай.");
            }
        }
    }
}
