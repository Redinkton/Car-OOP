namespace Vehicle
{
    internal class Passenger_Car : Car
    {
        public Passenger_Car()
        {
            AverageFuelConsumption = 12;
            FuelTank = 42;
            Speed = 90;
        }
        public int People { get; set; }
        public  void Start()
        {
            Console.Clear();
            Console.WriteLine("Сколько человек с собой возьмешь?");
            People = int.Parse(Console.ReadLine());
            double i = 0;
            if (People >= 1 & People <= 4)
            {
                Console.Clear();
                Console.WriteLine("Отлчично, должны поместиться!");
                i =SensorWithPeople(People);
                TimeLeft(Speed, AverageFuelConsumption,i);
            }
            else if (People == 0)
            {
                i = SensorEmpty();
                TimeLeft(Speed, AverageFuelConsumption,i);
            }
            else
            {
                Console.WriteLine("Нельзя столько человек в машину");
            }
        }
    }
}
