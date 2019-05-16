using jae.euler.math;
using System.Linq;

namespace jae.euler.lib
{
    public class E072CountingFractions
    {
        public long GetNumberOfProperFractions(int dmax)
        {
            Totient totient = new Totient(dmax);
            return  Enumerable.Range(2, dmax-1).Select(i => totient.Calc(i)).Sum();
        }           
    }
}
