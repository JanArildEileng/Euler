using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.util
{
    public class Star
    {
        public static string Hide(string tekst, int bitHidingPattern)
        {
            char[] charArray = tekst.ToCharArray();
            int MaxIndex = tekst.Length - 1;

            for (int index = 0; index <= MaxIndex; index++)
            {
                int bitIndex = 1 << index;

                //reverse..
                if ((bitIndex & bitHidingPattern) != 0)
                    charArray[MaxIndex - index] = '*';
            }

            return new string(charArray);
        }
    }
}
