using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E031CoinsumsUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
            In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:

            1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).
            It is possible to make £2 in the following way:

            1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
            How many different ways can £2 be made using any number of coins?     
            */

            /* NB: gjor alt om til pence : */

            var sut = new E031Coinsums();

            Assert.Equal(1, sut.GetNumberOfDifferentWays(amountInpence: 1, penceCoinsvalues: new int[] { 200, 100, 50, 20, 10, 5,2, 1 }));
            Assert.Equal(2, sut.GetNumberOfDifferentWays(amountInpence: 2, penceCoinsvalues: new int[] { 200, 100, 50, 20, 10, 5,2, 1 }));
            Assert.Equal(2, sut.GetNumberOfDifferentWays(amountInpence: 3, penceCoinsvalues: new int[] { 200, 100, 50, 20, 10, 5, 2, 1 }));
            Assert.Equal(3, sut.GetNumberOfDifferentWays(amountInpence: 4, penceCoinsvalues: new int[] { 200, 100, 50, 20, 10, 5, 2, 1 }));
            Assert.Equal(4, sut.GetNumberOfDifferentWays(amountInpence: 5, penceCoinsvalues: new int[] { 200, 100, 50, 20, 10, 5, 2, 1 }));

        }

        [Fact]
        public void Solution()
        {
            /*
               How many different ways can £2 be made using any number of coins?   
             */

            var sut = new E031Coinsums();
            Assert.Equal(73682, sut.GetNumberOfDifferentWays(amountInpence: 200, penceCoinsvalues: new int[] { 200,100, 50,20,10,5,2,1}));

            /*
              Congratulations, the answer you gave to problem 31 is correct.

                You are the 74542nd person to have solved this problem.
            */
        }
    }
}
