using System;

namespace CensusAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Census Analyser!");
            CensusAnalyserFactory censusAnalyser = new CensusAnalyserFactory();
            censusAnalyser.ShowCensus();
        }
    }
}
