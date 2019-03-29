using jae.euler.lib.Words;
using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E017Numberlettercounts
    {
        public int GetLettersused(int from, int to)
        {
            int lettersused = 0;

            for (int i=from; i<=to;i++)
            {
                lettersused += WritenNumbers.LetterCount(WritenNumbers.from(i));

            }

            return lettersused;
        }
    }
}
