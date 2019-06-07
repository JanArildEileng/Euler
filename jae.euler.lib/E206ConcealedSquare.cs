using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace jae.euler.lib
{
    public class E206ConcealedSquare
    {

        /*
             Find the unique positive integer whose square has the form 1_2_3_4_5_6_7_8_9_0,
              where each “_” is a single digit.
          */

        public long Square()
        {
            for (long i = 1010101010; i < 1010101030; i++)
            {

                BigInteger square=i*i;

                var st = square.ToString();
                if ( st.Length >19) throw new Exception($"to long square  {i}");
                if (st.Length < 19) continue;

                if (st[0]=='1' && st[2] == '2' && st[4] == '3' && st[6] == '4')
                {
                    if (st[8] == '5')
                    {
                        var a = 1;
                    }
                   
                }


            }

            throw new Exception($"not found");

        }



            public long Square2()
        {
        



                   
            for (long i=1010101010;i< 1010101020; i++)
            {
                List<int> liste1 = DigitsList.ConvertToDigitListe(i);
             

                List<int> square = DigitsList.Product(liste1, liste1);

                if (square.Count < 19) continue;
                if (square.Count > 19) throw new Exception($"to long square  {i}");


                square = DigitsList.ReverseCopy(square);

                bool a = true;

                for(int p=1;p<10;p++)
                {
                    //if (square[2 * p - 2] > p)
                    //    throw new Exception($"to big {i} {p}  {square[2 * p - 2]}");


                    if (square[2 *p -2 ] != p)
                    {
                        a = false;
                        break;
                    }
                }

                if (square[18] != 0)
                {
                    a = false;
                 
                }

                if (a) return i;

                
            }

            throw new Exception($"not found");
        }
    }
}
