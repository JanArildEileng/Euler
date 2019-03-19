using jae.euler.lib;
using System;
using Xunit;

namespace jae.euler.test
{
    public class E001Multiplesof3and5UnitTest

    {
        [Fact]
        public void Test1()
        {
            var sut = new E1Multiplesof3and5();

            var sum = sut.Sum(below:10);
            Assert.Equal(23, sum);

            sum = sut.Sum(below: 1000);
            Console.WriteLine( $"Sum  = { sum}" );


        }

        [Fact]
        public void Solution()
        {
            var e1Multiplesof3and5 = new E1Multiplesof3and5();
            var sum = e1Multiplesof3and5.Sum(below: 1000);
            Assert.Equal(233168, sum);
            // 233168
            //Congratulations, the answer you gave to problem 1 is correct.
            //You are the 833904th person to have solved this problem.

        }


    }
}
