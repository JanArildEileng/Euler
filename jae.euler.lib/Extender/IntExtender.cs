using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib.Extender
{
    public static class IntExtender
    {
        public static bool Even(this int a)
        {
            return a % 2 == 0;
        }

    }
}
