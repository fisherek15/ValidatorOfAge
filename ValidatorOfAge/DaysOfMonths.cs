using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorOfAge
{
    public static class DaysOfMonths
    {
        public static readonly List<int> DaysOfMonthsOfLapYear = new List<int>(){
            0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 
        };

        public static readonly List<int> DaysOfMonthsOfRegularYear = new List<int>{
            0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
        };
    }
}
