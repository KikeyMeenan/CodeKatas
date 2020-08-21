using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04_DataMunging_NetCore
{
    public class DatFileReader
    {
        public List<Func<string, bool>> RowValidators;

        public DatFileReader()
        {
            RowValidators = new List<Func<string, bool>>() { 
                input => !string.IsNullOrEmpty(input)
            };
        }

        public List<T> GetData<T>(string fileName, Func<IEnumerable<string>, T> CreateItem)
        {
            var results = new List<T>();

            var rows = GetValidDataRowsFromFile(fileName);

            foreach (var row in rows)
            {
                var validColumns = GetValidColumnsFromRow(row);

                results.Add(CreateItem(validColumns));
            }

            return results;
        }

        private IEnumerable<string> GetValidDataRowsFromFile(string fileName)
        {
            var reader = new StreamReader(fileName);
            var strAllFile = reader.ReadToEnd();
            string[] rows = strAllFile.Split(new char[] { '\n' });

            var validRows = rows.Where(row =>
            {
                var result = false;
                foreach (var validator in RowValidators)
                {
                    result = validator(row);
                }
                return result;
            });

            //skip first line, reverse, and skip again (all but first and last lines)
            //kinda dirty and really not clear what or why
            var dataRows = validRows.Skip(1).Reverse().Skip(1);

            return dataRows.Where(x => !string.IsNullOrEmpty(x));
        }

        private IEnumerable<string> GetValidColumnsFromRow(string row)
        {
            string[] columns = row.Split(@" ");

            return columns.Where(x => !string.IsNullOrEmpty(x));
        }
    }
}
