using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E092SquareDigitChains
    {
        
        Dictionary<int, bool> dict = new Dictionary<int, bool>(1000000);

        public int GetCount(int below, int arrivat)
        {
            int count = 0;
            for(int i=2;i<below;i++)
            {
                if (IsArrivingAt(i, arrivat))
                    count++;
            }
            return count;
        }

        public  bool IsArrivingAt(int number, int arrivat)
        {
            List<int> list = new List<int>(10);
            if (number <1000)
            list.Add(number);

         
            while (true)
            {
                if (dict.TryGetValue(number, out bool t))
                {
                    return t;
                }

                number = SumSquareDigits(number);
              //  if (number > 1000) throw new Exception($"number to big {number}");           

                if (number == arrivat)
                {
                    foreach (var l in list)
                        dict.Add(l, true);
                    return true;
                }

                if (number == 1)
                {
                    foreach (var l in list)
                        dict.Add(l, false);
                    return false;
                }
         
                list.Add(number);
            }

    
        }


        private int SumSquareDigits(int number)
        {
            List<int> list = DigitsList.ConvertToDigitListe(number);
            return list.Select(e => e * e).Sum();
        }


    }
}
