using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.util
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

        public static List<int> Product(List<int> numbers1, int maxDigits,int multiplier)
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
                if (i > maxDigits) break;
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

        public static List<int> ConvertToDigitListe(int numbers)
        {
            List<int> liste = new List<int>();

            liste.Add(numbers % 10);
            numbers = numbers / 10;
          
            while ( numbers > 0)
            {
                liste.Add(numbers % 10);
                numbers = numbers / 10;
            }

            return liste; ;
        }
        public static List<int> ConvertToDigitListe(long numbers)
        {
            List<int> liste = new List<int>();

            liste.Add( (int)(numbers % 10));
            numbers = numbers / 10;

            while (numbers > 0)
            {
                liste.Add((int)(numbers % 10));
                numbers = numbers / 10;
            }

            return liste; ;
        }




        public static int ConvertToNumber(List<int> liste)
        {
     
            int number = liste[0];
            int tenfactor = 1;
            for(int i=1;i< liste.Count;i++)
            {
                tenfactor *= 10;
                number = tenfactor * liste[i] + number;
            }
            return number; ;
        }


        public static long ConvertToNumberLong(List<int> liste)
        {

            long number = liste[0];
            long tenfactor = 1;
            for (int i = 1; i < liste.Count; i++)
            {
                tenfactor *= 10;
                number = tenfactor * liste[i] + number;
            }
            return number; ;
        }

        public static int ConvertToNumberHighesFirst(int [] array)
        {

            int number = array[0];

            int i = 1;
            while ( i < array.Length)
            {
                number = 10 * number + array[i];
                i++;
            }

            
            return number; ;
        }

    }
}
