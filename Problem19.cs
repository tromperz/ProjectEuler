using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem19
    {
        public int Sundays(int start, int end)
        {
            int year = start, month = 1, day = GetStartDay(start), count = 0;
            while(year <= end)
            {
                if (day == 1)
                {
                    count++;
                    day += 21;
                }

                day += 7;

                if(day>GetMonth(month,year))
                {
                    day -= GetMonth(month, year);
                    month++;
                }

                if(month > 12)
                {
                    month = 1;
                    year++;
                }
            }
            return count;
        }

        private int GetMonth(int month, int year)
        {
            int[] daysInMonth = new int[13] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (year % 4 == 0 && month == 2)
                return 29;
            else
                return daysInMonth[month];
        }

        private int GetStartDay(int year)
        {
            int day = 0;

            for(int i = 1900; i < year; i++)
            {
                if (i % 100 == 0)
                    if (i % 400 == 0)
                        day += 367;
                    else
                        day += 366;
                else
                    if (i % 4 == 0)
                        day += 367;
                    else
                        day += 366;
            }

            if (day % 7 == 0)
                return 1;
            else
                return (8-(day % 7));
        }
    }
}
