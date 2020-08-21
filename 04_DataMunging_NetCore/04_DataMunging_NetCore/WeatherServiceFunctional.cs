//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//namespace _04_DataMunging_NetCore
//{
//    static class WeatherServiceFunctional
//    {
//        public static int GetLowestSpread()
//        {
//            var rows = ReadFromDatFile.GetValidDataRowsFromFile("weather.dat");

//            int? lowestTempDifferenceDay = null;
//            int? lowestTempDifference = null;

//            for (int i = 0; i < rows.Count(); i++)
//            {
//                var validColumns = ReadFromDatFile.GetValidColumnsFromRow(rows.ElementAt(i));

//                var day = int.Parse(validColumns.ElementAt(0));
//                var tempDifference = int.Parse(validColumns.ElementAt(2)) - int.Parse(validColumns.ElementAt(1));

//                if (i == 0 || lowestTempDifference > tempDifference)
//                {
//                    lowestTempDifferenceDay = day;
//                    lowestTempDifference = tempDifference;
//                }
//            }

//            return lowestTempDifferenceDay.Value;
//        }

        
//    }
//}
