using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.lib.Extender;

namespace jae.euler.lib
{
    public class E024Lexicographicpermutation
    {
        int permutationOrderNumber;
        int permutationCounter;

        public string Getpermutations(int permutationOrderNumber, int[] startpermutationlist)
        {
            permutationCounter = 0;
            this.permutationOrderNumber = permutationOrderNumber;

            int[] currentpermutationlist = new int[startpermutationlist.Length];

            RecurivePerm(startpermutationlist, 0, currentpermutationlist);

            return currentpermutationlist.StringFromArray();
        }
        private bool RecurivePerm(int[] availableNumberlist,int currentLevel, int[] currentpermutation)
        {
            if (availableNumberlist.Length==1)
            {
                currentpermutation[currentLevel] = availableNumberlist[0];
                //current permutation complete
                permutationCounter++;
                //if found permutationOrderNumber return true(finished)
                return (permutationCounter == permutationOrderNumber) ;
            }

            foreach(int nextAviableNumber in availableNumberlist) {
                currentpermutation[currentLevel] = nextAviableNumber;
                //remove used number from availableNumberlist for next level
                if (RecurivePerm(availableNumberlist.Where(e => e != nextAviableNumber).ToArray(), currentLevel + 1, currentpermutation))
                    return true;
            }
            return false;
        }





    }
}
