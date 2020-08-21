using System;

namespace _04_DataMunging_NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherSpread = new WeatherServiceOO().GetLowestSpread();
            Console.WriteLine("Lowest weather spread is ", weatherSpread);

            var goalDifference = new FootballServiceOO().GetLowestGoalDifference();
            Console.WriteLine("Lowest goal difference is ", goalDifference);
        }
    }
}
