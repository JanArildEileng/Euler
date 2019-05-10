using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.math;

namespace jae.euler.lib
{
    public class E074DigitFactorialChains
    {
        public int GetNumberOfChains(int length, int below)
        {
            return Enumerable.Range(1, below - 1).
                        Select(i => ChainLoopLength(i)).
                        Where(l => l == length).
                        Count();
        }

        public int SumFactorialOfItsDigits(int number)
        {
            var digitsList = DigitsList.ConvertToDigitListe(number);

            return (int)digitsList.Select(i => Factorial.Factor(i)).Sum();
        }

        public int ChainLoopLength(int number)
        {
            Dictionary<int, int> numberDict = new Dictionary<int, int>(60);
            int counter = 1;
            numberDict.Add(number, 1);

            while (counter <= 60)
            {
                number = SumFactorialOfItsDigits(number);
                if (numberDict.ContainsKey(number))
                {
                    return counter;
                }
                else
                {
                    numberDict.Add(number, 1);
                    counter++;
                }
            }

            return -1;
        }
    }
}
