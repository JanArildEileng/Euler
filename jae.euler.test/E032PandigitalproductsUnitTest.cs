using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E032PandigitalproductsUnitTes
    {

        [Fact]
        public void Test1()
        {
            /*
             The product 7254 is unusual, as the identity, 39 × 186 = 7254, 
             containing multiplicand, multiplier, and product is 1 through 9 pandigital.            */

  

            var sut = new E032Pandigitalproducts();

            Assert.True(sut.IdentityIsPandig(multiplicand: 39, multiplier: 186,product: 7254));

            int p = 40 * 186;
            Assert.False(sut.IdentityIsPandig(multiplicand: 40, multiplier: 186, product: p));



        }

        [Fact]
        public void Solution()
        {
            /*
               Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital. 
             */

            var sut = new E032Pandigitalproducts();
           Assert.Equal(1, sut.GetSumOfAllPandigitalProucts());

            /*
              Congratulations, the answer you gave to problem 31 is correct.

                You are the 74542nd person to have solved this problem.
            */
        }
    }
}
