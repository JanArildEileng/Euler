using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E023Nonabundantsums
    {
        //    A number n is called called abundant if sum of its proper divisors exceeds n.
        public long GetNonabundantsum(int to)
        {

            //lag liste av aktuelle AbundantNumber 
            var abundantNumbersListe = Enumerable.Range(1, to).Where(i => Divisors.IsAbundantNumber(i)).ToList();

            //lag hashmap av AbundantNumber listen
            var abundantNumbersDictionary = abundantNumbersListe.ToDictionary(e => e);



            //finn summen  
            //er  i= a+b hvor a og b er AbundantNumber ? , ellers legg til sum
            long nonabundantsum = 0;


            for (int i = 1; i <= to; i++)
            {
                if (
                    abundantNumbersListe   
                    .Where(e => e < i)          
                    .Where(a => abundantNumbersDictionary.ContainsKey(i - a))
                    .FirstOrDefault() == 0     //hvis ikke i kan skrives som summen av to tall i abundantNumbersListe
                ) {
                    nonabundantsum += i;
                }
            }

            return nonabundantsum;
        }

       
    }
}
