using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.lib.Extender;

namespace jae.euler.lib
{
    public class E022Namesscores
    {
        /*

           begin by sorting it into alphabetical order. 
            Then working out the alphabetical value for each name, 
            multiply this value by its alphabetical position in the list to obtain a name score.
         */

        public long GetNamesscores(List<string> nameList)
        {
            long namesscores = 0;
    
            int alphabeticatposition = 1;

            foreach (string name in nameList.OrderBy(e => e).ToList())
            {
                 namesscores += alphabeticatposition * name.AlphabeticalValue(); 
                 alphabeticatposition++;     
            }

            return namesscores;
        }
    }
}
