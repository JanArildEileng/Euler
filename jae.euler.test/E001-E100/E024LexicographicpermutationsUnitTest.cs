using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E024LexicographicpermutationsUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
            A permutation is an ordered arrangement of objects. 
            For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. 
            If all of the permutations are listed numerically or alphabetically, 
            we call it lexicographic order. The lexicographic permutations of 0, 1 and 2 are:
            012   021   102   120   201   210
            */

            int[] list = { 0, 1, 2 };

            var sut = new E024Lexicographicpermutation();

            Assert.Equal("012", sut.Getpermutations(permutationOrderNumber: 1, startpermutationlist: new int[] { 0, 1, 2}));
            Assert.Equal("021", sut.Getpermutations(permutationOrderNumber: 2, startpermutationlist: new int[] { 0, 1, 2 }));
            Assert.Equal("102", sut.Getpermutations(permutationOrderNumber: 3, startpermutationlist: new int[] { 0, 1, 2 }));
            Assert.Equal("120", sut.Getpermutations(permutationOrderNumber: 4, startpermutationlist: new int[] { 0, 1, 2 }));
            Assert.Equal("201", sut.Getpermutations(permutationOrderNumber: 5, startpermutationlist: list));
            Assert.Equal("210", sut.Getpermutations(permutationOrderNumber: 6, startpermutationlist: list));

            Assert.Equal("0123", sut.Getpermutations(permutationOrderNumber: 1, startpermutationlist: new int[] { 0, 1, 2, 3}));
            Assert.Equal("0132", sut.Getpermutations(permutationOrderNumber: 2, startpermutationlist: new int[] { 0, 1, 2, 3}));
            Assert.Equal("0213", sut.Getpermutations(permutationOrderNumber: 3, startpermutationlist: new int[] { 0, 1, 2, 3}));
            Assert.Equal("0231", sut.Getpermutations(permutationOrderNumber: 4, startpermutationlist: new int[] { 0, 1, 2, 3}));
            Assert.Equal("0312", sut.Getpermutations(permutationOrderNumber: 5, startpermutationlist: new int[] { 0, 1, 2, 3}));
            Assert.Equal("0321", sut.Getpermutations(permutationOrderNumber: 6, startpermutationlist: new int[] { 0, 1, 2, 3}));

            Assert.Equal("0123456789", sut.Getpermutations(permutationOrderNumber: 1, startpermutationlist: new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
            Assert.Equal("0123456798", sut.Getpermutations(permutationOrderNumber: 2, startpermutationlist: new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
            Assert.Equal("0123456879", sut.Getpermutations(permutationOrderNumber: 3, startpermutationlist: new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
            Assert.Equal("0123456897", sut.Getpermutations(permutationOrderNumber: 4, startpermutationlist: new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
        }

        [Fact]
        public void Solution()
        {
            /*
              What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
            */
     
            var sut = new E024Lexicographicpermutation();

            Assert.Equal("2783915460", sut.Getpermutations(permutationOrderNumber: 1000000, startpermutationlist: new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));

            /*
                Congratulations, the answer you gave to problem 24 is correct.
                You are the 101482nd person to have solved this problem.
            */
        }
    }
}
