using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E068Magic5gonRing
    {
        int RingSlots;
        String bestString="00000";
        int MaxDigits;

        public string GetMaximumDigitString(int ringsize, int maxDigit)
        {
            RingSlots = ringsize * 2;
            MaxDigits = maxDigit;
            //gå rekursivt gjennom alle permutasjoner 
            var availablenumberList = Enumerable.Range(1, RingSlots);
            int currentRingPos = 0;
            int[] ring = new int[RingSlots];
            Recursiv(availablenumberList, currentRingPos, ring);

            return (bestString);

        }

        private  void Recursiv(IEnumerable<int> availablenumberList, int currentRingPos, int[] ring)
        {
            if (currentRingPos== RingSlots)
            {
                int antall = AllLineTotal(ring);
                if ( antall >0)
                {
                    var s = GetRingString(ring);
                    if (s.Length== MaxDigits &&  s.CompareTo(bestString) >0)
                    {
                        bestString = s;
                    }

                }

            } else
            {

                foreach(int availablenumber in availablenumberList)
                {
                    ring[currentRingPos] = availablenumber;
                    var nextAvaliAble = availablenumberList.Where(e => e != availablenumber).ToList();
                    Recursiv(nextAvaliAble, currentRingPos + 1, ring);

                }

              
            }

        }

        public int AllLineTotal(int[] ring)
        {
            // 1 siffer fra outer ring, 2 fra inner ring...
            int ringsize = ring.Length/2;

            int[] sum = new int[ringsize];

            for(int i=0;i< ringsize;i++)
            {
                sum[i] = ring[i];

                int offset =  ringsize + i;
                int offset2 = ringsize+ (i + 1) % ringsize;
                sum[i] += ring[offset] + ring[offset2];
            }


            if (sum.All(s => s == sum[0]))
                return sum[0];
            else
                return -1;
           



        }

        public string GetRingString(int[] ring)
        {
            int ringsize = ring.Length / 2;

            //start lowest external node
            int startLowestExternalNode = GetStartLowestExternalNode(ring);

            StringBuilder builder = new StringBuilder();

            for (int i=0;i< ringsize;i++)
            {
                int offset = (startLowestExternalNode + i) % ringsize;

                int offset1 = offset+ringsize;
                int offset2 = ringsize + (offset + 1) % ringsize;

                builder.Append(ring[offset]);
                builder.Append(ring[offset1]);
                builder.Append(ring[offset2]);
            }

            var s = builder.ToString();
            return s ;
        }


        private int GetStartLowestExternalNode(int[] ring)
        {
            int ringsize = ring.Length / 2;
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
