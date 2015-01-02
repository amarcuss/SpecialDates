using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialDates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start with January 1st, 1900
            DateTime today = new DateTime(1900,1,1);

            Console.WriteLine(today.ToLongDateString());
            
            //Go for 1000 years, should make this an argument
            while(today <  DateTime.Now.AddYears(1000))
            {
                // Month equals Day
                if (today.Month == today.Day)
                {
                    Console.WriteLine("Day = Month: " + today.ToLongDateString());
                }

                // Month equals Day AND Month == last two digists of year
                if ((today.Month == today.Day) && (today.Month == int.Parse(today.Year.ToString().Substring(2))))
                {
                    Console.WriteLine("Day = Month = Year: " + today.ToLongDateString());
                }

                // Day equals last two digits of year
                if (today.Day == int.Parse(today.Year.ToString().Substring(2)))
                {
                    Console.WriteLine("Day = Year: " + today.ToLongDateString());
                }
                
                // Increment year
                today = today.AddDays(1);

            }
            
            // End with a readline 
            Console.ReadKey();

        }
    }
}
