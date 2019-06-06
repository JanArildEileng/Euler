using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.util
{
    public class RomanNumber
    {

        struct mapper
        {
            public int v;
            public string s;
        }

        static List<mapper> map = new List<mapper>
            {
                new mapper {v=1000,s="M"},
                new mapper {v=900,s="CM"},
                new mapper {v=500,s="D"},
                new mapper {v=400,s="CD"},
                new mapper {v=100,s="C"},
                new mapper {v=90,s="XC"},
                new mapper {v=50,s="L"},
                new mapper {v=40,s="XL"},
                new mapper {v=10,s="X"},
                new mapper {v=9,s="IX"},
                new mapper {v=5,s="V"},
                new mapper {v=4,s="IV"},
                new mapper {v=1,s="I"}
            };

        public static string ToString(int number)
        {
            var s = makeRomanString(number);
            return s;
        }

        public static int ToInt(string str)
        {
            char[] charArray = str.ToCharArray().Reverse().ToArray();
          
            int number = 0;

            int last = 0;
            for(int i=0;i< charArray.Length;i++)
            {
                int current = romanCharToNumber(charArray[i]);
              
                if ( current < last)
                {
                    last = current;
                    current = -current;
                } else
                {
                    last = current;
                }
                number += current;

            }

            return number;
        }

        private static int romanCharToNumber(char c)
        {
            switch (c)
            {
                case 'M': return 1000;
                case 'D': return 500; ;
                case 'C': return 100;
                case 'L': return 50;
                case 'X': return 10;
                case 'V': return 5;
                case 'I': return 1;
            }
            throw new Exception($"Ukjent roman char {c}");
        }

        private static  string makeRomanString(int number)
        {
            StringBuilder builder = new StringBuilder();
            foreach(var m in map)
            {
                while (number >= m.v)
                {
                    builder.Append(m.s); number -= m.v;
                }
            }
            return builder.ToString();
        }


    }
}
