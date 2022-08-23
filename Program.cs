using System;
using Vehicle;
class Program
{
    static void Main(string[] args)
    {
        var passengerCar = new Passenger_Car();
        var truckCar = new Truck_Car();
        var sportCar = new Sport_Car();
        
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