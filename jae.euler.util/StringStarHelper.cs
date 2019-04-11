using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.util
{
    public class StringStarHelper:IEnumerable<string>
    {
        String Str;
        int Start;
        public StringStarHelper(string str,int start = 0)
        {
            this.Str = str;
            this.Start = start;
        }

        public IEnumerator<string> GetEnumerator()
        {
            char[] orgcarray = this.Str.ToCharArray();
         
            int Len = orgcarray.Length - Start;

            int max = 1 << Len;
            int i = 1;

            while ( i < max)
            {
                char[] carray = new char[Len];
                for (int j=1;j<= Len;j++)
                {
                    if ( (j & i )==j)
                    {
                        carray[Len-j] = '*';
                    }  else
                    {
                        carray[Len - j] = orgcarray[Len - j];
                    }
                }
                i++;
                var str = new String(carray);
                yield return str;

            }

            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
