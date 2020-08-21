using System;
using System.Collections.Generic;
using System.Text;

namespace _04_DataMunging_NetCore
{
    public static class DatFileReaderFactory
    {
        public static DatFileReader GetReader(string type = null)
        {
            if(type == "football")
            {
                return new FootballDatFileReader();
            }
            return new DatFileReader();
        }
    }
}
