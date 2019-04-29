using jae.euler.lib;
using Xunit;

namespace jae.euler.test.level01
{
    public class E001Multiplesof3and5UnitTest
    {
        [Fact]
        public void Test1()
        {
            var sut = new E001Multiplesof3and5();
            Assert.Equal(23, sut.Sum(below: 10));
        }

        [Fact]
        public void Solution()
        {
            var sut = new E001Multiplesof3and5();
            Assert.Equal(233168, sut.Sum(below: 1000));
            //Congratulations, the answer you gave to problem 1 is correct.
            //You are the 833904th person to have solved this problem.
        }
    }
}
