using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;
using jae.euler.lib;

namespace jae.euler.test.level01
{
    public class E002EvenFibonaccinumbersUnitTest
    {
        [Fact]
        public void Test1()
        {
            var list = new List<long> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89  };

            var sumTest = list.Where(e => e % 2 == 0).Sum();
            var max = list.Max()+1;

            var sut = new E002EvenFibonaccinumbers();

            var sum = sut.SumEven(below: max);
            Assert.Equal(sumTest, sum);
        }


        [Fact]
        public void Solution()
        {
            var sut = new E002EvenFibonaccinumbers();
            var sum = sut.SumEven(below: 4000000);
            Assert.Equal(4613732, sum);
            Console.WriteLine($"E2EvenFibonaccinumbers Sum  = { sum}");

            /*
            4613732
            Congratulations, the answer you gave to problem 2 is correct.
            You are the 666663rd person to have solved this problem.
          */

        }

    }
}
