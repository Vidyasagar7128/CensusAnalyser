using System;

namespace CensusAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Census Analyser!");
            CensusAnalyser censusAnalyser = new CensusAnalyser();
            censusAnalyser.ShowCensus();
        }
    }
}
