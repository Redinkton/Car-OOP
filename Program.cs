using System;
using Vehicle;
class Program
{
    static void Main(string[] args)
    {
        var passengerCar = new PassengerCar();
        var truckCar = new TruckCar();
        var sportCar = new SportCar();
        
    M: Console.WriteLine("Выбери автомобль для поездки: \n1.Passenger Car \n2.Sport Car \n3.Truck Car");
        int i = int.Parse(Console.ReadLine());
        
        switch (i)
        {
            case 1: passengerCar.Start();
                break;
            case 2:
                sportCar.Start();
                break;
            case 3:
                truckCar.Start();
                break;
            default: Output.BadChoice();
                goto M;
        }
    }
}