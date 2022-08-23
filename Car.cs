

namespace Vehicle
{
     public abstract class Car
    {
        //обьем топливного бака
        public double FuelTank { get; set ; }
        //средний расход
        protected double AverageFuelConsumption { get; set; }
        public double Speed { get; set; }


        //сколько сможет проехать пустое авто
        public static double ResidualDistanceEmpty(double fuelTank, double averageFuelConsumption)
        {
            double result = fuelTank*100/averageFuelConsumption;
            return Math.Round(result, 1);
        }
        //Сколько времени осталось проехать
        public void TimeLeft(double speed, double averageFuelConsumption, double i)
        {
            Output.AmountDistance();
            int km = int.Parse(Console.ReadLine());
            if (i < km)
            {
                Output.DistanceBad(km);
            }
            else
            {
                double result = i / speed;
                Output.DistanceGood(result);
            }
        }
        //датчик пустого авто
        public double SensorEmpty()
        {
            double i = ResidualDistanceEmpty(FuelTank, AverageFuelConsumption);
            Output.Sensor(i);
            return i;
        }



    }
}
