using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LatestLangFeatures
{
    
    public struct Coordinates
    {

        public Coordinates(double X,double Y)
        {
            x = X;
            y = Y;
        }

        public double x { get; }
        public double y { get; }

    }
}
