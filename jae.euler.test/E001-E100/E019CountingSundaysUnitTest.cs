using jae.euler.lib;
using System;
using Xunit;
using System.Linq;
using System.Text;

namespace jae.euler.test
{
    public class E019CountingSundaysUnitTest
    {
        [Fact]
        public void TestBaselineDates()
        {
            /*
             * 1 Jan 1900 was a Monday.
            */
             
            var fromDate = new DateTime(1900, 1, 1);

            var dayOfWeek = fromDate.DayOfWeek;
            Assert.Equal(DayOfWeek.Monday,dayOfWeek);

            int sundays = 0;
            for(int i = 1; i <= 12; i++)
            {
                var firstOfMonth = new DateTime(1900, i, 1);
                if (firstOfMonth.DayOfWeek == DayOfWeek.Sunday)
                    sundays++;
            }

            //2 sundays in 1900
            Assert.Equal(2, sundays);


            sundays = 0;
            for(int year=1901;year<= 2000; year++)
            for (int i = 1; i <= 12; i++)
            {
                var firstOfMonth = new DateTime(year, i, 1);
                if (firstOfMonth.DayOfWeek == DayOfWeek.Sunday)
                    sundays++;

            }
            //171 sundays in 1901 -2000
            Assert.Equal(171, sundays);
        }


        [Fact]
        public void Test1()
        {
            /*
                How many Sundays fell on the first of the month    1901/1902       
            */
            var sut = new E019CountingSundays();
            var fromDate = new DateTime(1901, 1, 1);
            var toDate = new DateTime(1902, 12, 31);
            int sundaysExpected = 3;
            int sundays = sut.CountingSundays(fromDate: fromDate, toDate: toDate);
            Assert.Equal(sundaysExpected, sundays);

        }

        [Fact]
        public void Solution()
        {
            /*
                How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
            */

            var sut = new E019CountingSundays();

            var fromDate = new DateTime(1901, 1, 1);
            var toDate = new DateTime(2000, 12, 31);

            int sundaysExpected = 171;
            int sundays = sut.CountingSundays(fromDate: fromDate, toDate: toDate);
            Assert.Equal(sundaysExpected, sundays);

            /*
              Congratulations, the answer you gave to problem 19 is correct.

                You are the 119283rd person to have solved this problem.
            */

        }


    }
}
