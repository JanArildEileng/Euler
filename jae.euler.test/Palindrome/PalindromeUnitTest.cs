using jae.euler.lib.Palindrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace jae.euler.test.Palindrome
{
    public class PalindromeUnitTest
    {

        [Theory]
        [InlineData(101)]
        [InlineData(1001)]
        [InlineData(10101)]
        public void TestIsPalindrome(long value)
        {
            Assert.True(PalindromeHelper.IsPalindrome(value));
            Assert.True(PalindromeHelper.IsPalindrome(value));
            Assert.True(PalindromeHelper.IsPalindrome(value));
        }

        [Theory]
        [InlineData(100)]
        [InlineData(1002)]
        [InlineData(102012)]
        public void TestIsNotPalindrome(long value)
        {
            Assert.False(PalindromeHelper.IsPalindrome(value));
         
        }

    }
}
