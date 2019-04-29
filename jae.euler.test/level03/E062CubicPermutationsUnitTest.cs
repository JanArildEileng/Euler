using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace jae.euler.test.level03
{
    public class E062CubicPermutationsUnitTest
    {



     

        [Fact]
        public void Test_1()
        {
            /*
                The cube, 41063625 (345^3), can be permuted to produce two other cubes: 56623104 (384^3) and 66430125 (405^3).
                 In fact, 41063625 is the smallest cube which has exactly three permutations of its digits which are also cube.             
             * 
               */
            var sut = new E062CubicPermutations();
            Assert.Equal(41063625, sut.GetSmallestCube(numberOfpermutations: 3));


        }


        [Fact]
        public void Solution()
        {
            /*
            Find the smallest cube for which exactly five permutations of its digits are cube.
            */

            var sut = new E062CubicPermutations();
            Assert.Equal(127035954683, sut.GetSmallestCube(numberOfpermutations: 5));



            /*
              Congratulations, the answer you gave to problem 62 is correct.

             You are the 27159th person to have solved this problem.
            */
        }
    }


}
