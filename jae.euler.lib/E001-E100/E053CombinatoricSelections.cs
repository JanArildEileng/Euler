using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.math;


namespace jae.euler.lib
{
    public class E053CombinatoricSelections
    {
        const int MILLION = 1000000;

        public int GetNumberOfCombinatoricSelections(int maxN)
        {
            int numberOfCombinatoricSelections = 0;

            for (int n = 1; n <= maxN; n++)
            {
                for (int r = 1; r <= n; r++)
                {
                    if (CNrAboveMillion(n, r))
                    {
                        numberOfCombinatoricSelections++;
                    }
                }
            }

            return numberOfCombinatoricSelections;
        }

        public bool CNrAboveMillion(int n, int r)
        {
            List<int> noverrliste = GetFactoralListe(n, r);
            List<int> nrliste = GetFactoralListe(n - r, 1);

            while (nrliste.Count() > 0)
            {
                noverrliste = ReduceLister(nrliste, noverrliste);
                nrliste = nrliste.Where(i => i != 1).ToList();

                nrliste = ReduceLister(noverrliste, nrliste);
                noverrliste = noverrliste.Where(i => i != 1).ToList();
                nrliste = ConvertToPrimeList(nrliste);
            }

            if (ProductAbove(noverrliste, MILLION))
            {
                return true; ;
            }

            return false;
        }

        private bool ProductAbove(List<int> liste, int limit)
        {
            int prod = 1;
            foreach (int item in liste)
            {
                prod *= item;
                if (prod > limit)
                {
                    return true;
                }
            }
            return false;
        }


        private static List<int> ConvertToPrimeList(List<int> nrliste)
        {
            if (nrliste.Count() > 0)
            {
                List<long> liste = new List<long>();
                foreach (int item in nrliste)
                {
                    liste.AddRange(Primes.GetPrimeFactorsInNumber(item));
                }
                nrliste = liste.Select(e => (int)e).ToList();
            }

            return nrliste;
        }

        private List<int> ReduceLister(List<int> aListe, List<int> bListe)
        {
            for (int i = 0; i < bListe.Count; i++)
            {
                for (int j = 0; j < aListe.Count; j++)
                {
                    if (aListe[j] % bListe[i] == 0)
                    {
                        aListe[j] = aListe[j] / bListe[i];
                        bListe[i] = 1;
                        break;
                    }
                }
            }
            return bListe.Where(i => i != 1).ToList();
        }

        private List<int> GetFactoralListe(int n, int from)
        {
            List<int> liste = new List<int>();

            while (n > from)
            {
                liste.Add(n);
                n--;
            }

            return liste;
        }

    }
}
