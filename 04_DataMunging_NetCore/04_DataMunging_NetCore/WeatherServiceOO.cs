using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04_DataMunging_NetCore
{
    public class WeatherServiceOO
    {
        DatFileReader DatFileReader = DatFileReaderFactory.GetReader();

        public int GetLowestSpread()
        {
            //could also add create item function as override on DatFileReader?
            var weatherSpreads = DatFileReader.GetData<WeatherSpread>("weather.dat",
                validColumns => new WeatherSpread(
                    int.Parse(validColumns.ElementAt(0)),
                    int.Parse(validColumns.ElementAt(1)),
                    int.Parse(validColumns.ElementAt(2))
                ));

            return weatherSpreads.OrderByDescending(x => x.Difference).FirstOrDefault().Day;
        }
    }

    public class WeatherSpread
    {
        public WeatherSpread(int day, int min, int max)
        {
            Day = day;
            Difference = max - min;
        }

        public int Day { get; }
        public int Difference { get; }
    }
}
