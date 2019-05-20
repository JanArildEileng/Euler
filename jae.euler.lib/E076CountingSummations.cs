using System.Collections.Generic;
using System.Linq;

namespace jae.euler.lib
{
    public class E076CountingSummations
    {     
        /*
         Hvor mange addisjoner inneholder minst like mange '1' som neste tall som skal brukes til å lage flere addisjoner.. 
          
         */ 

        public int GetNumberOfDifferentWays(int sum)
        {
            var tails = new List<int> { sum };
            int counter = 1;

            //loop gjennom alle tall opptil n
            for (int i=2;i<sum;i++)
            {
                tails = tails.Where(t => t >= i).ToList(); 

                int index = 0;
                while ( index < tails.Count)
                {
                    var restAntall = tails[index]-i;

                    if (restAntall >= 0  )
                    {
                        counter++;
                        if (restAntall >= i)
                        tails.Add(restAntall);
                    }
                    index++;
                }
            }
       
            return counter;
        }


        //public int GetNumberOfDifferentWays2(int sum)
        //{

        //    List<List<int>> tails = new List<List<int>>();
        //    tails.Add(Enumerable.Repeat(1, sum).ToList());


        //    int counter = 1;
        //    //loop gjennom alle tall opptil n
        //    for (int i = 2; i < sum; i++)
        //    {

        //        tails = tails.Where(t => t.Count() >= i).ToList();


        //        int index = 0;
        //        while (index < tails.Count)
        //        {
        //            var list = tails[index];

        //            if (list.Count >= i)
        //            {
        //                counter++;
        //                if ((list.Count - i) >= i)
        //                    tails.Add(Enumerable.Repeat(1, list.Count - i).ToList());
        //            }
        //            index++;
        //        }
        //    }

        //    return counter;
        //}


    }
}
