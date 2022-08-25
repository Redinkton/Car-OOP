namespace Vehicle
{
    internal class PassengerCar : Car
    {
        public PassengerCar()
        {
            AverageFuelConsumption = 12;
            FuelTank = 42;
            Speed = 90;
        }
        public int People { get; set; }
        public void Start()
        {
            Console.Clear();
            Output.AmooutPeople();
            People = int.Parse(Console.ReadLine());
            double i;
            if (People >= 1 & People <= 4)
            {
                Console.Clear();
                Output.StartGood();
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
                Output.StartBad();
            }
        }
        //сколько сможет проехать авто с людьми
        public double ResidualDistanceWithPeople(double fuelTank, double averageFuelConsumption, int people)
        {
            double withPeople = people * 6;
            //расход топлива с кол-вом человек в машине(6(6%) - это расход топлива на каждого чела)
            double fuelСonsumptionWithPeople = ((averageFuelConsumption / 100) * withPeople) + averageFuelConsumption;
            double result = fuelTank * 100 / fuelСonsumptionWithPeople;
            return Math.Round(result, 1);
        }
        public double SensorWithPeople(int people)
        {
            double i = ResidualDistanceWithPeople(FuelTank, AverageFuelConsumption, people);
            Output.Sensor(i);
            return i;
        }

    }
}
