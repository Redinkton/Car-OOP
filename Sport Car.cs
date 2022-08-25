namespace Vehicle
{
    internal class SportCar : Car
    {
        public SportCar()
        {
            AverageFuelConsumption = 15.6;
            FuelTank = 37;
            Speed = 180;
        }
        public void Start()
        {
            Console.Clear();
            SensorEmpty();
            Output.StartGoodSport();    
        }
    }

}
