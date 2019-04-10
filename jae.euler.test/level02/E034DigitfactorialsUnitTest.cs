using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test.level02
{
    public class E034DigitfactorialsUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
                   145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
           
            */

            var sut = new E034Digitfactorials();

            Assert.True(sut.IsCuriousNumber(145));
            Assert.False(sut.IsCuriousNumber(146));

            //hvert siffer kan maks bidra med 362880 til sluttsummen
            Assert.Equal(362880, Factorial.Factor(9));

            //  8*Factorial.Factor(9)=2903040
            //  7*Factorial.Factor(9)=2540160
            //minste tall med 8 siffer 10000000
            //altså er 2540160 max tallet som kan være et curios number
        }

        [Fact]
        public void Solution()
        {
            /*
              Find the sum of all numbers which are equal to the sum of the factorial of their digits.

             */

            var sut = new E034Digitfactorials();
            Assert.Equal(40730, sut.GetSumOfAllCuriousNumbers());
            /*
              Congratulations, the answer you gave to problem 34 is correct.

                You are the 83240th person to have solved this problem.
            */
        }
    }

    public class E000 {
    }
}
