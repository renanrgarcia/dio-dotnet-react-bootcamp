using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataListsChallenge.Exceptions
{
    public class SuiteCapacityExceededException : Exception
    {
        // Parameterless constructor
        public SuiteCapacityExceededException()
            : base("The number of guests is greater than:")
        {
        }
    }
}