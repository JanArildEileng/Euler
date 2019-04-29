using System.Linq;

namespace jae.euler.lib
{
    public class E001Multiplesof3and5
    {
        public int Sum(int below)
        {
            return
                Enumerable.
                Range(1, below-1).
                Where(i => (i % 3 == 0) || (i % 5 == 0)).
                Sum();
        }
    }
}
