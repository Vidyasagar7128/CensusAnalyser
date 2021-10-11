using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyser
{
    public class CustomException : Exception
    {
        public CustomException(String massege) : base(massege)
        {
        }
    }
}
