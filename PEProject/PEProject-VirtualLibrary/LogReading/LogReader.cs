using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
namespace SearchSystem_ZartAlgorithm.LogReading
{
    public class LogReader
    {
        public static readonly string WorkingDirectory = Environment.CurrentDirectory;
        public static readonly string TextFilePath = Directory.GetParent(WorkingDirectory).Parent.Parent.Parent.FullName + @"\Resources\logs_BCS37_20181103.csv";

        public static List<LogClass> Log()
        {
            using (var reader = new StreamReader(TextFilePath))
            using (var csv = new CsvReader(reader))
            {
                return csv.GetRecords<LogClass>().ToList();
            }
        }
    }
}
