using jae.euler.math;

namespace jae.euler.lib
{ 
    public class E004Largestpalindromeproduct
    {
        public long Largest(long maxFactor)
        {
            long largestpalindromeFound = -1;

            for (long i1 = maxFactor - 1; i1 > 0; i1--)
            {
                if (i1 * i1 < largestpalindromeFound) break;

                for (long i2 = i1; i2 > 0; i2--)
                {
                    long currentProduct = i1 * i2;
                    if (currentProduct > largestpalindromeFound)
                    {
                        if (Palindrome.IsPalindrome(currentProduct))
                            largestpalindromeFound = currentProduct;
                    }
                    else
                        break;
                }
            }

            return largestpalindromeFound;
        }
    }
}
