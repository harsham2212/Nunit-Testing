using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class DayOfWeek
    {
        public void Day(int day, int month, int year)
        {

            Console.WriteLine("Day is " + dayOfWeek(day, month, year));
        }
        public static int dayOfWeek(int d, int m, int y)
        {
            int ye = y - (14 - m) / 12;
            int x = ye + ye / 4 - ye / 100 + ye / 400;
            int mo = m + 12 * ((14 - m) / 12) - 2;
            int da = (d + x + (31 * mo) / 12) % 7;
            Console.WriteLine("Here the Date is:" + da);
            return da;
        }
    }
}
