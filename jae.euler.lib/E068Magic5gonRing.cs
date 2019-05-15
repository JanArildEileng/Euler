using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E068Magic5gonRing
    {
        String maximunStringString="";
        int MaxDigitsInLineString;

        public string GetMaximumDigitString(int ringsize, int maxDigit)
        {
            int RingSlots = ringsize * 2;
            MaxDigitsInLineString = maxDigit;
            //gå rekursivt gjennom alle permutasjoner 
            var availablenumberList = Enumerable.Range(1, RingSlots);
            int currentRingPos = 0;
            int[] currentRing = new int[RingSlots];
            Recursiv(availablenumberList, currentRingPos, currentRing);

            return (maximunStringString);

        }

        private  void Recursiv(IEnumerable<int> availablenumberList, int currentRingPos, int[] currentRing)
        {
            if (currentRingPos== currentRing.Length)
            {
                if (AllLineTotal(currentRing) > 0)
                {
                    var ringString = GetRingString(currentRing);
                    if (ringString.Length== MaxDigitsInLineString && ringString.CompareTo(maximunStringString) >0)
                    {
                        maximunStringString = ringString;
                    }
                }
            } else
            {
                foreach(int availablenumber in availablenumberList)
                {
                    currentRing[currentRingPos] = availablenumber;
                    var nextAvaliAble = availablenumberList.Where(e => e != availablenumber).ToList();
                    Recursiv(nextAvaliAble, currentRingPos + 1, currentRing);
                }
            }
        }


        //sjekk om alle 'liner' gir samme sum..
        public int AllLineTotal(int[] ring)
        {
            // 1 siffer fra outer ring, 2 fra inner ring...
            int ringsize = ring.Length/2;

            int[] lineSum = new int[ringsize];

            for(int i=0;i< ringsize;i++)
            {
                lineSum[i] = ring[i] + ring[ringsize + i] + ring[ringsize + (i + 1) % ringsize];
            }

            return lineSum.All(s => s == lineSum[0]) ? lineSum[0] : -1;
        }

        public string GetRingString(int[] ring)
        {
            int ringsize = ring.Length / 2;

            //start lowest external node
            int startLowestExternalNode = GetStartOfLowestExternalNode(ring, ringsize);

            StringBuilder builder = new StringBuilder();

            for (int i=0;i< ringsize;i++)
            {
                int offset = (startLowestExternalNode + i) % ringsize;
        
                builder.Append(ring[offset]);
                builder.Append(ring[offset + ringsize]);
                builder.Append(ring[ringsize + (offset + 1) % ringsize]);
            }

            return builder.ToString();
        }


        private int GetStartOfLowestExternalNode(int[] ring,int ringsize)
        {
            int low = ring[0];
            int startLowestExternalNode=0;

            for (int i=1;i< ringsize;i++)
            {
                if (ring[i] < low) {
                    low = ring[i];
                    startLowestExternalNode = i;
                }
            }
            return startLowestExternalNode;
        }

    }
}
