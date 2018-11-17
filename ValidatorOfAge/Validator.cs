using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorOfAge
{
    static class Validator
    {
        public static DateTime today = DateTime.Today;
        public static bool IsAdult(DateOfBirth dateOfBirth)
        {
            if (today.Year - dateOfBirth.Year > 18)
                return true;

            if (today.Year - dateOfBirth.Year == 18)
            {
                if (today.Month - dateOfBirth.Month > 0)
                    return true;

                if (today.Month - dateOfBirth.Month == 0)
                {
                    if (today.Day - dateOfBirth.Day >= 0)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            } else
                return false;        
        }
    }
}
