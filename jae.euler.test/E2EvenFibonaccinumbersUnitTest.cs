using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;
using jae.euler.lib;

namespace jae.euler.test
{
    public class E2EvenFibonaccinumbersUnitTest
    {
        [Fact]
        public void Test1()
        {
            var list = new List<int> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89  };

            var sumTest = list.Where(e => e % 2 == 0).Sum();
            var max = list.Max()+1;

            var sut = new E2EvenFibonaccinumbers();

            var sum = sut.SumEven(below: max);
            Assert.Equal(sumTest, sum);
        }


        [Fact]
        public void Solution()
        {
            var sut = new E2EvenFibonaccinumbers();
            var sum = sut.SumEven(below: 4000000);
            Assert.Equal(4613732, sum);
            Console.WriteLine($"E2EvenFibonaccinumbers Sum  = { sum}");
        }

    }
}
