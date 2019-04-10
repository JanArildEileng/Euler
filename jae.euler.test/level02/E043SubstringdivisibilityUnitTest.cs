using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test.level02
{
    public class E043SubstringdivisibilityUnitTest
    {
     
        [Fact]
        public void Test1()
        {
            /*
                The number, 1406357289, is a 0 to 9 pandigital number because it is made up of each of the digits 0 to 9 in some order, but it also has a rather interesting sub-string divisibility property.

                Let d1 be the 1st digit, d2 be the 2nd digit, and so on. In this way, we note the following:

                d2d3d4=406 is divisible by 2
                d3d4d5=063 is divisible by 3
                d4d5d6=635 is divisible by 5
                d5d6d7=357 is divisible by 7
                d6d7d8=572 is divisible by 11
                d7d8d9=728 is divisible by 13
                d8d9d10=289 is divisible by 17         
            */

            var sut = new E043Substringdivisibility();
           
            Assert.True(sut.HasSubstringdivisibility(1406357289));
            Assert.True(sut.HasSubstringdivisibility(4160357289 ));           
            Assert.False(sut.HasSubstringdivisibility(1406395728));
        }
    


        [Fact]
        public void Solution()
        {
            /*
            Find the sum of all 0 to 9 pandigital numbers with this property.
            */

            var sut = new E043Substringdivisibility();
           
            Assert.Equal(16695334890, sut.GetSumWithSubStringProperty());

            /*
               Congratulations, the answer you gave to problem 43 is correct.

                You are the 52362nd person to have solved this problem.
             */
        }
    }

    
}
