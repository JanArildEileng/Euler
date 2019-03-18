using System.Linq;
using jae.euler.lib.Fibonacci;
using jae.euler.lib.Extender;

namespace jae.euler.lib
{
    public class E2EvenFibonaccinumbers
    {
        public int SumEven(int below)
        {
            var list = FibonacciSequence.GenFibonacciSequence(below);

            var sum = list.Where(e => e.Even()).Sum();
            return sum;
        }

    }
}
