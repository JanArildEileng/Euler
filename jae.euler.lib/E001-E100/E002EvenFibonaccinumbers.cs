using System.Linq;
using jae.euler.lib.Extender;
using jae.euler.math;

namespace jae.euler.lib
{
    public class E002EvenFibonaccinumbers
    {
        public long SumEven(long below)
        {
            Fibonacci fibonacci = new Fibonacci();
            return fibonacci.Iterator(below).Where(e => e.Even()).Sum();

        }

    }
}
