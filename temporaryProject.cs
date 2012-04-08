using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace vacation_tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime vacation = new DateTime(2012, 4, 23);
            DateTime endVacation = new DateTime(2012, 5, 6);
            int numberVacationDays = endVacation.DayOfYear - vacation.DayOfYear;

            Calendar vacationTrecker = CultureInfo.InvariantCulture.Calendar;
            int counter = 0;
      
            for (int i = 0; i < numberVacationDays; i++)
            {
                vacation = vacationTrecker.AddDays(vacation, 1);
                Console.WriteLine(vacation);

                bool saturdayChecker = Equals(vacation.DayOfWeek, DayOfWeek.Saturday);
                            
                Console.WriteLine(saturdayChecker);
                if (vacation.DayOfWeek == DayOfWeek.Wednesday)
                {
                    counter++;
                }
               
            }
            Console.WriteLine("Result:    {0}", counter);
            Console.ReadLine();
        }
    }
}