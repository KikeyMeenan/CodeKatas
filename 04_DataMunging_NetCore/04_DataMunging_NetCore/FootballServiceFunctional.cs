//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//namespace _04_DataMunging_NetCore
//{
//    public class FootballServiceFunctional
//    {

//        DatFileReader DatFileReader = new FootballDatFileReader();

//        public string GetLowestGoalDifference()
//        {
//            var rows = DatFileReader.GetValidDataRowsFromFile("football.dat");

//            string lowestGoalDifferenceTeam = "";
//            int? lowestGoalDifference = null;

//            for (int i = 0; i < rows.Count(); i++)
//            {
//                var validColumns = DatFileReader.GetValidColumnsFromRow(rows.ElementAt(i));

//                var team = validColumns.ElementAt(1);
//                var tempDifference = int.Parse(validColumns.ElementAt(6)) - int.Parse(validColumns.ElementAt(8));

//                if (i == 0 || lowestGoalDifference > tempDifference)
//                {
//                    lowestGoalDifferenceTeam = team;
//                    lowestGoalDifference = tempDifference;
//                }
//            }

//            return lowestGoalDifferenceTeam;
//        }

        
//    }
//}
