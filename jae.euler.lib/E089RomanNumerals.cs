using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.util;

namespace jae.euler.lib
{
    public class E089RomanNumerals
    {
        public int FindNumberCharactersSaved(string[] lines)
        {
            int charPreCount = lines.Select(l => l.Length).Sum();

            for(int i=0;i< lines.Length;i++)
            {
                var l = efficient(lines[i]);
                if ( l.Length< lines[i].Length)
                {
                    lines[i] = l;
                }
            }

            int charPostCount = lines.Select(l => l.Length).Sum();
            return charPreCount- charPostCount;
        }

        private string efficient(string roman)
        {
            int number = RomanNumber.ToInt(roman);
            return RomanNumber.ToString(number);
        }
      
    }
}
