using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E102TriangleContainment
    {
        public bool ContaingOrigion(string coordinatString)
        {
            var coordinates = coordinatString.Split(',').Select(e => double.Parse(e)).ToList();

            var x = new List<double>
            {
                coordinates[0],coordinates[2],coordinates[4]
            };

            var y = new List<double>
            {
                coordinates[1],coordinates[3],coordinates[5]
            };


            if (!(x.Max() > 0 && x.Min() < 0 && y.Max() > 0 && y.Min() < 0))
                return false;
            //finn først det ene hjørenet som ligger alene på høyre eller venstre siden av y-aksen
            //finn så skjæringspunketene ( y-aksen) for linjene til de andre punktene, 
            //dersom disse skjæringspunkene har ulike fortegn, er origin i trianglet...

            (double bx1, double bx2) yCross=(0,0);
            if (  (x[0] >0 & x[1] <0 && x[2]<0) || (x[0] < 0 & x[1] > 0 && x[2] > 0))
            {
                yCross = CalcYCross(x, y);
            };

            if ( (x[1] > 0 & x[0] < 0 && x[2] < 0) || (x[1] < 0 & x[0] > 0 && x[2] > 0))
            {
                yCross = CalcYCross(new List<double> { x[1],x[0],x[2]} , new List<double> { y[1], y[0], y[2] });
            };

            if ( (x[2] > 0 & x[0] < 0 && x[1] < 0) || (x[2] < 0 & x[0] > 0 && x[1] > 0))
            {
               yCross = CalcYCross(new List<double> { x[2], x[1], x[0] }, new List<double> { y[2], y[1], y[0] });
            };

            return (yCross.bx1 * yCross.bx2 <= 0) ? true : false;
        }

        public int GetNumberOfTrianglesContaingOrigion(string[] coordinateList)
        {
            int numberOfTrianglesContaingOrigion = 0;
            foreach (var coordinate in coordinateList) {
                if  ( ContaingOrigion(coordinate))
                {
                    numberOfTrianglesContaingOrigion++;
                }
            }

            return numberOfTrianglesContaingOrigion;
        }

        private (double bx1,double bx2) CalcYCross(List<double> x, List<double> y )
        {
             double[] ax1 =
             {
                     (y[1]-y[0])/(x[1]-x[0]),
                     (y[2]-y[0])/(x[2]-x[0])
             };

            return (y[0] - ax1[0] * x[0], y[0] - ax1[1] * x[0]);
        }


    }
}
