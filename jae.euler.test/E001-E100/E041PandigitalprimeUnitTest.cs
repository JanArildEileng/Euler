using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E041PandigitalprimeUnitTest
    {
     
        [Fact]
        public void Test1()
        {
            /*
                 We shall say that an n-digit number is pandigital
                 if it makes use of all the digits 1 to n exactly once.
                 For example, 2143 is a 4-digit pandigital and is also prime. 
            */

            var sut = new E041Pandigitalprime();
           
            Assert.Equal(4231, sut.GetLargestPandigitalPrime(4));

            Assert.Equal(1, sut.GetLargestPandigitalPrime(2));
            Assert.Equal(1, sut.GetLargestPandigitalPrime(3));
        }
    


        [Fact]
        public void Solution()
        {
            /*
            What is the largest n - digit pandigital prime that exists?     
            */

            var sut = new E041Pandigitalprime();
           
            Assert.Equal(7652413, sut.GetLargestPandigitalPrime(9));

            /*
               Congratulations, the answer you gave to problem 41 is correct.
                You are the 59958th person to have solved this problem.
             */
        }
    }

    
}
