using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace jae.euler.test.level03
{
    public class E060PrimePairSetsUnitTest
    {



        [Fact]
        public void Test0()
        {
            /*
                  The primes 3, 7, 109, and 673, are quite remarkable. 
                  By taking any two primes and concatenating them in any order the result will always be prime. 
              */
            var sut = new E060PrimePairSets(1000000);

            Assert.False(sut.IsConcatenatingPrimes(2,3));
            Assert.False(sut.IsConcatenatingPrimes(3, 5));
            Assert.True(sut.IsConcatenatingPrimes(3, 7));
            Assert.True(sut.IsConcatenatingPrimes(7, 109));
            Assert.True(sut.IsConcatenatingPrimes(673, 109));
        }


        [Fact]
        public void Test1()
        {
            /*
                  The primes 3, 7, 109, and 673, are quite remarkable. 
                  By taking any two primes and concatenating them in any order the result will always be prime. 
                  For example, taking 7 and 109, both 7109 and 1097 are prime. 
                  The sum of these four primes, 792, represents the lowest sum for a set of four primes with this property.
            */
            var sut = new E060PrimePairSets(10000);

            Assert.Equal(792, sut.GetLowestSum(pairsetSize: 4));



        }


        [Fact]
        public void Solution()
        {
            /*
              Find the lowest sum for a set of five primes for which any two primes concatenate to produce another prime.
            */

            var sut = new E060PrimePairSets(10000);
            Assert.Equal(26033, sut.GetLowestSum(pairsetSize: 5));


            /*
              Congratulations, the answer you gave to problem 60 is correct.

                You are the 22761st person to have solved this problem.
            */
        }
    }


}
