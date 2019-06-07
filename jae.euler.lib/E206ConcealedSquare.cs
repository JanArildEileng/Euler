using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

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
        //    Regex regex = new Regex(@"1\d{1}2\d{1}3\d{1}4\d{1}5\d{1}6\d{1}7\d{1}8\d{1}9\d{1}0");

            for (long i = 1010101010; i < 3120202030; i+=10)
            {
                BigInteger square=i*i;

        
                var st = square.ToString();
                if ( st.Length >19) throw new Exception($"to long square  {i}");
                if (st.Length < 19) continue;


         //       if  ( regex.IsMatch(st))
          //          return i;
             
               
                if ( st[0]=='1' &&  st[2]=='2' &&  st[4]=='3' &&  st[6]=='4' &&           
                     st[8]=='5' && st[10]=='6' && st[12]=='7' && st[14]=='8' &&
                    st[16]=='9' && st[18]=='0')
                    {
                        return i;
                    }                 
                             
            }

            throw new Exception($"not found");
        }
    }
}
