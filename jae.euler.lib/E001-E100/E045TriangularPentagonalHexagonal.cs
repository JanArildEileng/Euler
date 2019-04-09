using jae.euler.math;

namespace jae.euler.lib
{
    public class E045TriangularPentagonalHexagonal
    {
        public long GetNext(long next)
        {

            while (true)
            {
                var nextTriangleNumber = TriangleNumber.GetNumber(next);

                if (Pentagonnumber.GetN(nextTriangleNumber) > 0 && HexagonalNumber.GetN(nextTriangleNumber) > 0)
                    return nextTriangleNumber;

                next++;
            }

        }
    }
}
