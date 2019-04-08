using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.math;

namespace jae.euler.lib
{
    public class E047Distinctprimesfactors
    {
        public long GetFirstConsecutivenumberWith(int primefactors,int numberConsecutive)
        {
            //TODO:ytelse...!
            long number = 1;
            while(true)
            {

                long distinctprimeFactorsInNumber = 0;
                for (int j=0;j< numberConsecutive;j++)
                {
                    distinctprimeFactorsInNumber = Primes.GetPrimeFactorsInNumber(number+j).Distinct().Count();
                  //  distinctprimeFactorsInNumber = GetDistinctprimeFactorsInNumber(number + j, primefactors);
                    if (distinctprimeFactorsInNumber != primefactors)
                    {
                        number += j ;
                        break;
                    }
                }

                if (distinctprimeFactorsInNumber == primefactors)
                    return number;



                number++;



            }




        }


        public  long GetDistinctprimeFactorsInNumber(long number,int maxprimefactors)
        {
           var rest = number;
            var current = 2;
            int primefactors = 0;
            bool first = true;


            while (current <= rest)
            {
                if (rest % current == 0)
                {
                        if (first)
                    {
                        primefactors++;
                        first = false;
                        if (primefactors > maxprimefactors) return -1;
                    }

                    rest = rest / current;
                }
                else
                {
                    first = true;
                    current++;
                }
            }

            return primefactors;
        }
    }
}
