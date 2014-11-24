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
            DateTime today = new DateTime(1900,1,1);
            Console.WriteLine(today.ToLongDateString());
            

            while(today <  DateTime.Now.AddYears(1000))
            {
                //Console.WriteLine(today.ToLongDateString());
                /*
                if (today.Month == today.Day)
                {
                    Console.WriteLine("Day = Month: " + today.ToLongDateString());
                }
                */
                if ((today.Month == today.Day) && (today.Month == int.Parse(today.Year.ToString().Substring(2))))
                {
                    Console.WriteLine("Day = Month = Year: " + today.ToLongDateString());
                }


                today = today.AddDays(1);
            }

            Console.ReadKey();

        }
    }
}
