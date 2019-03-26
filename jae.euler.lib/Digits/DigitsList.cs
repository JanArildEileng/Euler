using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib.Digits
{
    public class DigitsList
    {

        public static  List<int> Product(List<int> numbers1, int multiplier)
        {
            List<int> sum = new List<int>();
            int rest = 0;
            int i = 0;
            while (numbers1.Count > i || rest > 0)
            {
                int s = rest;
                s += numbers1.Count > i ? numbers1[i] * multiplier : 0;
                sum.Add(s % 10);
                rest = s / 10;
                i++;
            }

            return sum;

        }


        public static List<int> Sum(List<int> numbers1, List<int> numbers2)
        {
            List<int> sum = new List<int>();
            int rest = 0;
            int i = 0;
            while (numbers1.Count > i || numbers2.Count > i || rest > 0)
            {
                int s = rest;
                s += numbers1.Count > i ? numbers1[i] : 0;
                s += numbers2.Count > i ? numbers2[i] : 0;

                sum.Add(s % 10);
                rest = s / 10;
                i++;
            }

            return sum;

        }
    }
}
