using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorOfAge_ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Year of your birth: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Month of your birth: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Day of your birth: ");
            int day = int.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime dateOfBirth = new DateTime(year, month, day);

            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age)) age--;
            Console.WriteLine(age);
        
            if (age >= 18)
                Console.WriteLine("You can drink an alcohol ;>");
            else
                Console.WriteLine("You must not drink an alcohol!");                
        }
    }
}
