using System.Linq;

namespace _04_DataMunging_NetCore
{
    public class FootballServiceOO
    {
        DatFileReader DatFileReader = DatFileReaderFactory.GetReader("football");

        public string GetLowestGoalDifference()
        {
            var goalDifferences = DatFileReader.GetData<GoalDifference>("football.dat", 
                validColumns => new GoalDifference(
                    validColumns.ElementAt(1),
                    int.Parse(validColumns.ElementAt(6)),
                    int.Parse(validColumns.ElementAt(8))
                ));

            return goalDifferences.OrderByDescending(x => x.Difference).FirstOrDefault().Team;
        }
    }

    public class GoalDifference
    {
        public GoalDifference(string team, int goalsFor, int goalsAgainst)
        {
            Team = team;
            Difference = goalsFor - goalsAgainst;
        }

        public string Team { get; }
        public int Difference { get; }
    }
}
