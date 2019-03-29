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


        public static string StringFromArray(this int[] list)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < list.Length; i++)
                builder.Append(list[i]);

            return builder.ToString();
        }

    }
}
