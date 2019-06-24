using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E145ReversibleNumbers
    {
        public int GetBelow(int below)
        {
            int counter = 0;
            List<int> digitsListe = DigitsList.ConvertToDigitListe(0);

           for (int i=1;i<below;i++)
           {
                digitsListe = DigitsList.Add1(digitsListe);
              
                if (i % 10 == 0) continue;
                int count = digitsListe.Count();
               
                bool reverible = true;
                int rest = 0;
                for(int d=0;d< count;d++)
                {
                    int digitplusreverse = digitsListe[d] + digitsListe[count - d - 1] + rest;
                    int s = digitplusreverse % 10;
                 
                    if ( s % 2==0)
                    {
                        reverible = false;
                        break;
                    }
                    rest = digitplusreverse / 10;
                }

                if (reverible)
                    counter++;

           }

            return counter;
        }


    




    }
}
