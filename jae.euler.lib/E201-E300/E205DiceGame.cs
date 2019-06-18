using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E205DiceGame
    {
        /*        Peter has nine four-sided(pyramidal) dice, each with faces numbered 1,  2, 3, 4.
        Colin has six six-sided(cubic) dice, each with faces numbered 1, 2, 3, 4, 5, 6.
        */

        double[] pyramidalProbablitity;
        double[] cubicProbablitity;

        public E205DiceGame()
        {
            pyramidalProbablitity= calcProbablity(9,4);
            cubicProbablitity = calcProbablity(6, 6);
        }

        public string GetProbablitityPyramidalBeatsCubic()
        {
            double total = 0.0;

            for(int i=1;i<=36;i++)
            {
                double pyramidalP = pyramidalProbablitity[i];
                double sumCubicProbablitity = cubicProbablitity.Take(i).Sum();
                total += sumCubicProbablitity * pyramidalP;
            }

            return $"{total:0.0000000}";
        }


        private double[] calcProbablity(int diceNummbers, int maxValue)
        {
            int size= (diceNummbers * maxValue) + 1;
            int[] counts = new int[size];

            Action<int> increaseCount = (value) =>
              {
                  counts[value]++;
              };

            ThrowDice(diceNummbers, maxValue, 0, increaseCount);
            var sum = counts.Sum(); ;

            var probablitity = counts.Select(e => 1.0 * e / sum).ToArray();
            return probablitity;
        }


        private void ThrowDice(int diceNummber,int maxValue,int sumValue,Action<int> action)
        {
            if (diceNummber == 0)
            {
                action(sumValue);
                return;
            }
            for (int value = 1; value <= maxValue; value++)
            {
                ThrowDice(diceNummber - 1, maxValue, sumValue+value,action);
            }
        }

        
    }
}
