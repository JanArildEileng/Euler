using System.Collections.Generic;
using System.Linq;

namespace jae.euler.lib
{
    public class E026Reciprocalcycles
    {
        struct divrest
        {
            public int div;
            public int rest;
        }


        public int Getlongestrecurringcycledenominator(int maxdenominator)
        {
            int longestrecurringcycle = 0;
            int longestrecurringcycledenominator = 1;
            for (var denominator=2; denominator<= maxdenominator; denominator++)
            {
                int recurringcycle = Getrecurringcycle(denominator);
                if (recurringcycle > longestrecurringcycle)
                {
                    longestrecurringcycle = recurringcycle;
                    longestrecurringcycledenominator = denominator;
                }
            }
            return longestrecurringcycledenominator;
        }

        private int Getrecurringcycle(int denominator)
        {
            List<divrest> cycleListe = new List<divrest>();

            int cycle = 1;
            int numerator = 10;

            int div = numerator / denominator;
            int rest = numerator % denominator;
            cycleListe.Add(new divrest { div = div, rest = rest });
            

           
                
            while (rest > 0 ) {
                rest = rest * 10;
                div = rest / denominator;
                rest = rest % denominator;
              

                if ( cycleListe.Where(e=>e.div==div && e.rest==rest).Count() >0)
                {
                    return cycleListe.Count();
                } else
                {
                    cycleListe.Add(new divrest { div = div, rest = rest });
                }
               
               
            }


                    
            return cycleListe.Count();
        }
    }
}
