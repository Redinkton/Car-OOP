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
