using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace jae.euler.test.level03
{
    public class E068Magic5gonRingUnitTest
    {

        [Fact]
        public void Test_AllLineTotal()
        {
            var sut = new E068Magic5gonRing();

            Assert.Equal(9, sut.AllLineTotal(ring: new int[]{ 4,6,5,3,2,1 }));
            Assert.Equal(9, sut.AllLineTotal(ring: new int[] { 4, 5, 6, 2, 3, 1 }));
            Assert.Equal(-1, sut.AllLineTotal(ring: new int[] { 4, 5, 6, 3, 2, 1 }));
            Assert.Equal(10, sut.AllLineTotal(ring: new int[] { 2,4,6, 3, 5, 1 }));
            Assert.Equal(12, sut.AllLineTotal(ring: new int[] { 1, 3, 2, 6, 5, 4 }));
        }

        [Fact]
        public void Test_GetRingString()
        {
            var sut = new E068Magic5gonRing();

            Assert.Equal("432621513", sut.GetRingString(ring: new int[] { 4, 6, 5, 3, 2, 1 }));

        }





        [Fact]
        public void Test_1()
        {
            /*
                   
            */
            var sut = new E068Magic5gonRing();
            Assert.Equal("432621513", sut.GetMaximumDigitString(ringsize: 3, maxDigit: 9));


        }

        [Fact]
        public void Solution()
        {
            /*
               What is the maximum 16-digit string for a "magic" 5-gon ring?
            */



            var sut = new E068Magic5gonRing();

            Assert.Equal("6531031914842725", sut.GetMaximumDigitString(ringsize: 5, maxDigit: 16));
            /*
            Congratulations, the answer you gave to problem 68 is correct.

            You are the 17945th person to have solved this problem.

            This problem had a difficulty rating of 25%. 
            */
        }
    }
}
