using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.util;

namespace jae.euler.lib
{
    public class E043Substringdivisibility
    {
        List<long> numbersWithSubstringdivisibility;


        public long GetSumWithSubStringProperty()
        {
            numbersWithSubstringdivisibility = new List<long>();
            int[] candidates = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 ,0};

            long number = 0;
            RecurivePerm(number,candidates);


            return numbersWithSubstringdivisibility.Sum();
        }

        private void RecurivePerm(long number, int[] availableNumberlist)
        {
            if (availableNumberlist.Length == 1)
            {
                number = number * 10 + availableNumberlist[0];
                if (HasSubstringdivisibility(number))
                {
                    numbersWithSubstringdivisibility.Add(number);
                    return;
                }
                return;
            }

            foreach (int nextAviableNumber in availableNumberlist)
            {
                RecurivePerm(number * 10 + nextAviableNumber, availableNumberlist.Where(e => e != nextAviableNumber).ToArray());
              
            }     
        }

        /*
          
              Let d1 be the 1st digit, d2 be the 2nd digit, and so on. In this way, we note the following:
              d2d3d4=406 is divisible by 2
              d3d4d5=063 is divisible by 3
              d4d5d6=635 is divisible by 5
              d5d6d7=357 is divisible by 7
              d6d7d8=572 is divisible by 11
              d7d8d9=728 is divisible by 13
              d8d9d10=289 is divisible by 17         
          */

        public bool HasSubstringdivisibility(long number)
        {
            var digitListe = DigitsList.ConvertToDigitListe(number);
            digitListe.Reverse();
            var digitArray = digitListe.ToArray();

            int[] dividors = { 2, 3, 5, 7, 11, 13, 17 };

            for(int i=0;i< dividors.Length;i++)
            {
                int value= DigitsList.ConvertToNumberHighesFirst(digitArray.Skip(i + 1).Take(3).ToArray());             
                if (value % dividors[i] != 0) return false;
            }
      
            return true;
        }


    }
}
