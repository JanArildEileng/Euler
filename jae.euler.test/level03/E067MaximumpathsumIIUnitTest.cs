using jae.euler.lib;
using System;
using Xunit;
using System.Linq;
using System.Text;
using System.IO;

namespace jae.euler.test.level03
{
    public class E067MaximumpathsumIIUnitTest
    {
        private string[] GetTriangleFromFile()
        {     
           var triangleString = File.ReadAllText("DataFiles\\p067_triangle.txt");
           return triangleString.Split(new char[] { '\n', '\r' }).Where(e => e.Length > 0).ToArray();
        }

        [Fact]
        public void Solution()
        {
            /*
                Find the maximum total from top to bottom of the triangle below:
            */
    
            var sut = new E018MaximumpathsumI();
            Assert.Equal(7273, sut.GetMaximumpathsum(GetTriangleFromFile()));

            /*
               Congratulations, the answer you gave to problem 67 is correct.
               You are the 86410th person to have solved this problem.
               This problem had a difficulty rating of 5%. 
            */
        }
    }
}
