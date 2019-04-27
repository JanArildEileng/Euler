using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E060PrimePairSets
    {
        List<long> primliste;
    
        public E060PrimePairSets(int primelistemax)
        {
            primliste = Primes.GetPrimeFactorsBelowNumber(primelistemax);
         }


        public long GetLowestSum(int pairsetSize)
        {
            List<List<long>> allLists = new List<List<long>>();


            long lowesteSum = long.MaxValue;

            int primeIndex = 0;
          

            while (primliste[primeIndex]< lowesteSum)
            {
                List<List<long>> tmpListe = new List<List<long>>();
                //sjekk alle pairlisteer
                foreach (List<long> pairlist in allLists)
               {
                    

                    //hvis matcher alle i en liste, opprett ny kopi liste, legg til current
                    if (pairlist.All(e=> IsConcatenatingPrimes(e, primliste[primeIndex]))) {
                        List<long> copyListe = pairlist.ToList();
                        copyListe.Add(primliste[primeIndex]);
                        tmpListe.Add(copyListe);

                        //komplett sett funnet...
                        if (copyListe.Count== pairsetSize)
                        {
                            long sum = copyListe.Sum();
                            if (sum < lowesteSum)
                            {
                                lowesteSum = sum;
                                return lowesteSum;
                                //er dette laveste sum?
                            }                               
                        }
                    }

                }
                allLists.AddRange(tmpListe);


                //ikke opprett flere liste hvis lowesteSum  allerede er funnet
                //if (lowesteSum < long.MaxValue)
                //{

                //    long diff = lowesteSum - primliste[primeIndex];

                //    allLists = allLists.Where(l => l.Sum() < diff).ToList();

                //    primeIndex++;
                //    continue;
                //}

                //hvis match på tidliger prime, opprett ny pairsliste
                for (int i= 0;i< primeIndex;i++)
                {
                    if (IsConcatenatingPrimes(primliste[i], primliste[primeIndex]))
                    {
                        List<long> nyListe = new List<long> { primliste[i], primliste[primeIndex] };
                     
                        allLists.Add(nyListe);
                    }

                }


                primeIndex++;
            }



            return lowesteSum;

        }


      
        public bool IsConcatenatingPrimes(long prime1, long prime2)
        {
            string s1 = prime1.ToString() + prime2.ToString();
            long p1 = long.Parse(s1);

         

            if (Primes.IsPrime(p1, primliste))
            {
                s1 = prime2.ToString() + prime1.ToString();
                p1 = long.Parse(s1);
            
                if (Primes.IsPrime(p1, primliste))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
