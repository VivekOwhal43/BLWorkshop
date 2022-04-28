using System.Collections.Generic;
using System.Diagnostics;

namespace MyWorkshop
{
    class Program
    {
        int day, month, year;
        static void dayOfWeek()
        {
            int day, d0;
            int month, m0;
            int year, y0;
            int x;
            Console.WriteLine("Please enter a date(input should be integer)");
            Console.WriteLine("Please enter day");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter month");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter year");
            year = Convert.ToInt32(Console.ReadLine());
            // formula No 1:  y0 = y − (14 − m) / 12
            y0 = year - (14 - month) / 12;
            //Formula No. 2: x = y0 + y0/4 − y0/100 + y0/400
            x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            //formula no 3: m0 = m + 12 × ((14 − m) / 12) − 2
            m0 = month + 12 * ((14 - month) / 12);
            //formula no 4: d0 = (d + x + 31m0/ 12) mod 7
            d0 = (day + x + 31 * (m0 / 12)) % 7;

            switch (d0)
            {
                case 0:
                    Console.WriteLine("Day is Sunday");
                    break;

                case 1:
                        Console.WriteLine("Day is Monday");
                    break;
                case 2:
                    if (d0 == 2)
                        Console.WriteLine("Day is Tuesday");
                    break;
                case 3:
                    if (d0 == 3)
                        Console.WriteLine("Day is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Day is Thursday");

                    break;
                case 5:
                    Console.WriteLine("Day is Friday");

                    break;
                case 6:
                    Console.WriteLine("Day is Saturday");

                    break;
            }
        }
        static void Main(string[] args)
        {
            dayOfWeek();
        }
    }
}