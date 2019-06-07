using jae.euler.lib;
using System.IO;
using System.Text.RegularExpressions;
using Xunit;

namespace jae.euler.test.level05
{
    public class E102TriangleContainmentUnitTest
    {


        private string[] ReadFile()
        {
            // -340,495,-153,-910,835,-947


            string[] coordinates = File.ReadAllLines(@"DataFiles\p102_triangles.txt");
            return coordinates;
        }


        [Theory]
        [InlineData("10,10,10,0,-10,-10")]
        public void Test_ContaingOrigion(string coordinates)
        {

            var sut = new E102TriangleContainment();
            Assert.True(sut.ContaingOrigion(coordinates));
        }

        [Theory]
  //      [InlineData("10,10,10,0,0,10")]
        [InlineData("10,0,8,10,-1,-5")]
        public void Test_NotContaingOrigion(string coordinates)
        {

            var sut = new E102TriangleContainment();
            Assert.False(sut.ContaingOrigion(coordinates));
        }





        [Fact]
        public void Test_ABC()
        {

            string[] coordinates = ReadFile();
            Assert.Equal(1000, coordinates.Length);
            var sut = new E102TriangleContainment();
            Assert.True(sut.ContaingOrigion(coordinates[0]));
        }

        [Fact]
        public void Test_XYZ()
        {

            string[] coordinates = ReadFile();
            var sut = new E102TriangleContainment();
            Assert.False(sut.ContaingOrigion(coordinates[1]));
        }





        [Fact]
        public void Solution()
        {
            /*
                find the number of triangles for which the interior contains the origin.
               
            */
            string[] coordinates = ReadFile();


            var sut = new E102TriangleContainment();
            Assert.Equal(228, sut.GetNumberOfTrianglesContaingOrigion(coordinates));

            /*
              Congratulations, the answer you gave to problem 102 is correct.
              You are the 19200th person to have solved this problem.
              This problem had a difficulty rating of 15%
             
            */
        }
    }
}
