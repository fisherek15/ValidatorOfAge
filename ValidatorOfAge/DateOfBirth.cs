using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorOfAge
{
    class DateOfBirth
    {
        public int Day { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }
        private bool IsLapYear { get; set; }

        public void SetYear(int year)
        {
            if (year > 0)
            {
                Year = year;
                CheckLapYear(Year);
            }
            else
                throw new Exception("Year must be greater than 0.");
        }

        public void SetMonth(int month)
        {
            if (month > 0 && month < 13)
                Month = month;
            else
                throw new Exception("Number of the month must be greater than 0 and smaller than 13.");
        }

        public void SetDay(int day)
        {
            if (day > 0) {
                if (IsLapYear)
                {
                    if (day > DaysOfMonths.DaysOfMonthsOfLapYear[Month])
                        throw new Exception("The month has less days.");              
                }
                if (!IsLapYear)
                {
                    if (day > DaysOfMonths.DaysOfMonthsOfRegularYear[Month])                       
                        throw new Exception("The month has less days.");
                }
                Day = day;
            } else
                throw new Exception("Number of the day must be greater than 0");
        }


        private void CheckLapYear(int year)
        {
            if (year % 4 == 0)
                IsLapYear = true;
            else
                IsLapYear = false;
        }
    }
}
