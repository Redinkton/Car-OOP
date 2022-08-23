using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Output
    {
        public static void StartGood() => Console.WriteLine("Отлчично, можем ехать!");
        public static void StartGoodSport() => Console.WriteLine("Сейчас поедем дрифтовать!");

        public static void StartBad() => Console.WriteLine("Нельзя столько человек в машину");
        
        public static void StartBadCargo() => Console.WriteLine("Куда столько взял, ты видел моё гнилое днище? Давай разгружай.");
        
        public static void AmountCargo() => Console.WriteLine("Сколько кило груза повезем сегодня?");
        public static void AmooutPeople() => Console.WriteLine("Сколько человек с собой возьмешь?");
        public static void AmountDistance() => Console.WriteLine("Сколько километров нам нужно проехать?");
        public static void DistanceBad(int km) => Console.WriteLine($"Мы не можем проехать {km}км, давай сначала на заправку!");
        public static void DistanceGood(double result) => Console.WriteLine($"По времени нам ехать: {Math.Round(result * 60, 0)} минут(ы)");
        public static void Sensor(double i)=> Console.WriteLine($"Датчики: сможем проехать {i}км");
        public static void BadChoice () => Console.WriteLine("Дам время подумать и выбрать еще раз!!!!");


    }
}
