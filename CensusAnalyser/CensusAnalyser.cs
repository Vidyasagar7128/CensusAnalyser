using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace CensusAnalyser
{
    class CensusAnalyser
    {
        List<Census> censusList = new List<Census>();
        string csvFile = @"C:\Users\vidya\Desktop\DotNet\DummyFiles\census.csv";

        public void ShowCensus()
        {
            using (var reader = new StreamReader(csvFile))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Census>();
                Console.WriteLine("Data Fetched Succesfully from CSV File!");
                Console.WriteLine("-----------------------------------");
                foreach (var i in records)
                {
                    Console.WriteLine($"{i.state}:  {i.population}");
                    Console.WriteLine("-----------------------------------");
                }
            }
        }
    }
}