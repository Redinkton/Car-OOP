namespace Vehicle
{
     public class Car
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
        //сколько сможет проехать авто с людьми
        public double ResidualDistanceWithPeople(double fuelTank, double averageFuelConsumption, int people)
        {
                double withPeople = people * 6;
                //расход топлива с кол-вом человек в машине(6(6%) - это расход топлива на каждого чела)
                double fuelСonsumptionWithPeople = ((averageFuelConsumption / 100) * withPeople) + averageFuelConsumption;
                double result = fuelTank * 100 / fuelСonsumptionWithPeople;
                return Math.Round(result,1);         
        }
        //сколько сможет проехать авто с грузом
        public double ResidualDistanceWithCargo(double cargo,double averageFuelConsumption, double fuelTank)
        {    
                double withCargo = cargo * 4;
                double fuelСonsumptionWithPeople = ((averageFuelConsumption / 100) * withCargo) + averageFuelConsumption;
                double result = fuelTank * 100 / fuelСonsumptionWithPeople;
            return Math.Round(result, 1);
        }
        public void TimeLeft(double fuelInTank, double speed, double averageFuelConsumption, double i)
        {
            Console.WriteLine("Сколько километров нам нужно проехать?");
            int km = int.Parse(Console.ReadLine());
            if (i < km)
            {
                Console.WriteLine($"Мы не можем проехать {km}км, давай сначала на заправку!");
            }
            else
            {
                double result = i / speed;
                Console.WriteLine($"По времени нам ехать: {Math.Round(result*60,0)} минут(ы)");
            }
        }
        //датчики 
        public double SensorEmpty()
        {
            double i = ResidualDistanceEmpty(FuelTank, AverageFuelConsumption);
            Console.WriteLine($"Датчики: сможем проехать {i}км");
            return i;
        }
        public double SensorWithPeople(int people)
        {
            double i = ResidualDistanceWithPeople(FuelTank, AverageFuelConsumption, people);
            Console.WriteLine($"Датчики: сможем проехать {i}км");
            return i;
        }
        public double SensorWithCargo(double cargo)
        {
            double i = ResidualDistanceWithCargo(cargo,AverageFuelConsumption, FuelTank);
            Console.WriteLine($"Датчики: сможем проехать {i}км");
            return i;
        }

    }
}
