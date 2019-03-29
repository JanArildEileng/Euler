using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E019CountingSundays
    {
        public int CountingSundays(DateTime fromDate, DateTime toDate)
        {
            int sundays = 0;
            int []thirtydaysmonth = new int[]{ 4, 6, 9, 11 };
      

            var date1901_1_01 = new DateTime(1901, 1, 1);
            int DaysFrom_1900_1_01 = CalcDaysFrom_1900_1_01(date1901_1_01);
            int dayOfWeek_1900_1_01 = DaysFrom_1900_1_01 % 7;  // 0=monday; 6 ==sunday


             DateTime currentDate = fromDate;

            int daysAdded = 0;

            int year = currentDate.Year;
            int month = currentDate.Month;
            int day = currentDate.Day;

            while (year <= toDate.Year && month<= toDate.Month && day<= toDate.Day)
            {
                //sjekk om ny mnd
                if (day == 31 || (day == 30 && thirtydaysmonth.Contains(month) )) { day = 0; month++; }

                if (month == 2 && ( day == 29 || (day == 28 && year % 4 != 0) || (day == 28 && (year % 100 == 0 && year % 400 != 0)))) { day = 0; month++; }

                
                //sjekk om neste år
                if ( month > 12 ) { month = 1; year++; }

                //sjekk om sønday er på 1st
                if (day==1)
                {
                   if (  (DaysFrom_1900_1_01+ daysAdded) % 7==6)
                    {
                        sundays++;
                    }
                }

                //neste dag

                daysAdded++;
                day++;
            }

            return sundays;
        }


        public int CalcDaysFrom_1900_1_01(DateTime currentDate)
        {
            var fromDate = new DateTime(1900, 1, 1);

            int daysAdded = 0;

            while (currentDate> fromDate)
            {
                fromDate=fromDate.AddDays(1);
                daysAdded++;
            }

            return daysAdded;
        }

       

    }
}
