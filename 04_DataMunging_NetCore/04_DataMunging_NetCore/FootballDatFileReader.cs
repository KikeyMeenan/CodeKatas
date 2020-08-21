namespace _04_DataMunging_NetCore
{
    public class FootballDatFileReader: DatFileReader
    {
        public FootballDatFileReader()
        {
            RowValidators.Add(input => input != "   -------------------------------------------------------");
        }
    }
}
