using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;

namespace jae.euler.test.level03
{
    public class E053CombinatoricSelectionsUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
            */
            var sut = new E053CombinatoricSelections();
            Assert.True(sut.CNrAboveMillion(23, 10));
            Assert.False(sut.CNrAboveMillion(22, 10));
        }

   

    



        [Fact]
        public void Solution()
        {
            /*
                How many, not necessarily distinct, values of nCr for 1≤n≤100, are greater than one-million?    
            */

            var sut = new E053CombinatoricSelections();
            Assert.Equal(4075, sut.GetNumberOfCombinatoricSelections(100));

            /*
               Congratulations, the answer you gave to problem 53 is correct.
               You are the 52005th person to have solved this problem.
            */
        }
    }


}
