using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.util
{
    public class DigitsList
    {

        public static List<int> ReverseCopy(List<int> digits)
        {
            List<int> reverseList = digits.ToList();
            reverseList.Reverse();
            return reverseList;

        }



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


        public static List<int> Product(List<int> numbers1, List<int> numbers2)
        {
            int ten = 1;
            List<int> sum = new List<int>();

            for (int i=0;i< numbers2.Count;i++)
            {
                int multiplier = ten*numbers2[i];

                var temp = Product(numbers1, multiplier);
                sum = Sum(sum, temp);

                ten *= 10;
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


        public static List<int> Substract(List<int> numbers1, List<int> numbers2)
        {
            List<int> sum = new List<int>();
            int trans = 0;
            int i = 0;
            while (numbers1.Count > i || numbers2.Count > i )
            {
                int s1= numbers1.Count > i ? numbers1[i] : 0;
                int s2= numbers2.Count > i ? numbers2[i] : 0;

                int s = s2 + trans;




                if (s <= s1)
                {
                    trans = 0;
                    sum.Add(s1 - s);
                } else
                {
                    trans = 1;
                    int add = 10 + s1 - s;
                    sum.Add(add);
                }

                 i++;
            }

            while(sum.Count >1 && sum.Last()==0)
            {
                sum = sum.SkipLast(1).ToList();
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
