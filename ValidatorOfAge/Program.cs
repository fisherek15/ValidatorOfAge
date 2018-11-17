using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorOfAge
{
    class Program
    {
        static void Main(string[] args)
        {
            DateOfBirth dateOfBirth = new DateOfBirth();

            Console.Write("Year of your birth: ");
            dateOfBirth.SetYear(int.Parse(Console.ReadLine()));

            Console.Write("Month of your birth: ");
            dateOfBirth.SetMonth(int.Parse(Console.ReadLine()));

            Console.Write("Day of your birth: ");
            dateOfBirth.SetDay(int.Parse(Console.ReadLine()));

            if(Validator.IsAdult(dateOfBirth))
                Console.WriteLine("You can drink an alcohol ;>");
            else
                Console.WriteLine("You must not drink an alcohol!");

        }
    }
}
