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
            Output.AmountCargo();
            Cargo = int.Parse(Console.ReadLine());
            if (Cargo >= 1 & Cargo <= 1000)
            {
                Console.Clear();
                
                Output.StartGood();
                SensorWithCargo(Cargo);

            }
            else if (Cargo == 0)
            {
                Output.StartGood();
                SensorEmpty();
            }
            else 
            {
                Output.StartBadCargo();
            }
        }
        //сколько сможет проехать авто с грузом
        public double ResidualDistanceWithCargo(double cargo, double averageFuelConsumption, double fuelTank)
        {
            double withCargo = cargo * 4;
            double fuelСonsumptionWithPeople = ((averageFuelConsumption / 100) * withCargo) + averageFuelConsumption;
            double result = fuelTank * 100 / fuelСonsumptionWithPeople;
            return Math.Round(result, 1);
        }
        public double SensorWithCargo(int cargo)
        {
            double i = ResidualDistanceWithCargo(cargo, AverageFuelConsumption, FuelTank);
            Output.Sensor(i);
            return i;
        }
    }
}
