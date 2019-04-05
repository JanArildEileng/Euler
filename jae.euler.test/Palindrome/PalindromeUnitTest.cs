using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace jae.euler.test.PalindromeUnitTest
{
    public class PrimeUnitTest
    {

        [Theory]
        [InlineData(101)]
        [InlineData(1001)]
        [InlineData(10101)]
        public void TestIsPalindrome(long value)
        {
            Assert.True(Palindrome.IsPalindrome(value));
            Assert.True(Palindrome.IsPalindrome(value));
            Assert.True(Palindrome.IsPalindrome(value));
        }

        [Theory]
        [InlineData(100)]
        [InlineData(1002)]
        [InlineData(102012)]
        public void TestIsNotPalindrome(long value)
        {
            Assert.False(Palindrome.IsPalindrome(value));
         
        }


        [Theory]
        [InlineData(585)]
        public void TestIsPalindromeBase2(long value)
        {
            Assert.True(Palindrome.IsPalindromeBase2(value));
        }

        [Theory]
        [InlineData(585)]
        public void TestalindromicBothBases(long value)
        {
            Assert.True(Palindrome.IsPalindromicBothBases(value));
        }


       
    }
}
