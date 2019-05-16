using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E059XORDecryption
    {
        public int GetSumAssicOfDekryptetText(List<int> cipherListe)
        {
            int start = (int)'a';
            int slutt = (int)'z';

           // the encryption key consists of three lower case characters
           // lag alle kobinasjon inntil treff
            for (int i1=start;i1<= slutt;i1++)
            {
                for (int i2= start; i2 <= slutt; i2++)
                {
                    for (int i3 = start; i3 <= slutt; i3++)
                    {
                        int key = (( (i1 << 8 ) +i2 ) <<8 ) + i3 ;
                        var str=TryDekrypt(cipherListe, key);

                        if (str!=null &&  str.Contains("the ") && str.Contains(" is ") )
                        {
                            var sum=str.ToCharArray().ToList().Sum(e => (int)e);
                            return sum;
                        }
                    }
                }
            }

            throw new Exception("Dekryptert tekst ikke funnet");
        }

        private string TryDekrypt(List<int> cipherListe, int key)
        {

            int len = cipherListe.Count;
            char[] charbuffer = new char[len];
            int insertIndex = 0;

            int index =0;
            while ( index< len) {
                // slå sammen 3 tall , og dekrypter dette
                int i1 = cipherListe[index++]<<16;
                int i2 = cipherListe[index++]<<8;
                int i3 = cipherListe[index++];
              
                int dekrypt = (i1 + i2 + i3) ^ key;

                // hent ut 3 char fra dekryptert tall
                int c1 = dekrypt >> 16;
                int c2 = (dekrypt >> 8)  & 255;
                int c3 = (dekrypt) & 255;

                //hvis none-ascci , abort..ikke gyldig nøkkel
                if (c1 > 127 || c2 > 127 || c3 > 127) return null;
           
                charbuffer[insertIndex++] = (char)c1;
                charbuffer[insertIndex++] = (char)c2;
                charbuffer[insertIndex++] = (char)c3;
            }

            return new string(charbuffer);

        }






        public char GetXor(char value, char key)
        {
            int b = (int)value;
            int k = (int)key;
            int xorresult = b ^ k;        
            return (char)xorresult; ;
        }
    }
}
