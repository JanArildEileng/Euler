using jae.euler.lib;
using System;
using Xunit;
using System.Linq;

namespace jae.euler.test
{
    public class E015LatticepathsUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
              Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, 
              there are exactly 6 routes to the bottom right corner.  
                 
            */

            var sut = new E015Latticepaths();

            long expectedroutes = 6;
        

            var routes = sut.GetRoutes(row:2,column:2);
            Assert.Equal(expectedroutes, routes);
     
        }

        [Fact]
        public void Solution()
        {
            /*
          How many such routes are there through a 20×20 grid? 
            */

            var sut = new E015Latticepaths();
            long expectedroutes = 137846528820;


            var routes = sut.GetRoutes(row: 20, column: 20);
            Assert.Equal(expectedroutes, routes);



            /*
                Congratulations, the answer you gave to problem 15 is correct.

                You are the 164861st person to have solved this problem.
            */

        }


    }
}
