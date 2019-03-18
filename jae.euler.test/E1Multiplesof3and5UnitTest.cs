using jae.euler.lib;
using System;
using Xunit;

namespace jae.euler.test
{
    public class Multiplesof3and5UnitTest

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


        }


    }
}
