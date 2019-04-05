using jae.euler.lib.Words;
using Xunit;


namespace jae.euler.test.wordsTest
{
    public class WritenNumbersUnitTest
    {




        [Fact]
        public void TestWritenNumbers()
        {
            /*
            If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
                
           NOTE: Do not count spaces or hyphens. 
           For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. 
           The use of "and" when writing out numbers is in compliance with British usage. 
           //*/
            Assert.Equal("one", WritenNumbers.from(1));
            Assert.Equal("ten", WritenNumbers.from(10));
            Assert.Equal("eleven", WritenNumbers.from(11));
            Assert.Equal("nineteen", WritenNumbers.from(19));
            Assert.Equal("twenty-two", WritenNumbers.from(22));
            Assert.Equal("thirty", WritenNumbers.from(30));
            Assert.Equal("seventy-seven", WritenNumbers.from(77));
            Assert.Equal("one hundred", WritenNumbers.from(100));
            Assert.Equal("three hundred and sixty", WritenNumbers.from(360));
            Assert.Equal("three hundred and sixty-five", WritenNumbers.from(365));
            Assert.Equal("one thousand", WritenNumbers.from(1000));

            Assert.Equal("three hundred and forty-two", WritenNumbers.from(342));
            Assert.Equal("one hundred and fifteen", WritenNumbers.from(115));

        }

        [Fact]
        public void TestWritenNumbersLetters()
        {
            /*
            If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
                
           NOTE: Do not count spaces or hyphens. 
           For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. 
           The use of "and" when writing out numbers is in compliance with British usage. 
           //*/

            //Assert.Equal("three hundred and forty-two", WritenNumbers.from(342));
            Assert.Equal(23, WritenNumbers.LetterCount("three hundred and forty-two"));
            Assert.Equal(20, WritenNumbers.LetterCount("one hundred and fifteen"));



        }



    }
}
