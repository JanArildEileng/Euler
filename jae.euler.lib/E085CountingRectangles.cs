using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E085CountingRectangles
    {
        public long GetContainingRectangels(int width, int height)
        {
            long containingRectangels = 0;
            for (int ystart=0;ystart< height;ystart++)
            {
                for (int yslutt = ystart+1; yslutt <= height ; yslutt++)
                {
                    for (int xstart = 0; xstart < width ; xstart++)
                    {
                        for (int xslutt = xstart + 1; xslutt <= width; xslutt++)
                        {
                            containingRectangels++;
                        }
                    }
                }
            }

            return containingRectangels;
        }

        public int GetAreaNearestSolution()
        {
            long closestcontainingRectangelsDiff = long.MaxValue;
            int areaNearestSolution = 0;


            for (int width=1; width<100; width++)
            {

                for (int height = 1; height < 100; height++)
                {
                    long containingRectangels = GetContainingRectangels(width, height);

                    long diff = Math.Abs(2000000 - containingRectangels);
                    if (diff > closestcontainingRectangelsDiff) break;

                    closestcontainingRectangelsDiff = diff;
                    areaNearestSolution = height * width;
                }
            }

            return areaNearestSolution;
        }
    }
}
