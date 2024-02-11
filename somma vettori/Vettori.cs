using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somma_vettori
{
    internal class Vettori
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vettori(double x, double y)
        {
            X = x;
            Y = y;
        }
        public static Vettori operator +( Vettori vec1, Vettori vec2)
        {
            return new Vettori(vec1.X + vec2.X, vec1.Y + vec2.Y);
        }
        public override string ToString() 
        {
            return string.Format("{0};{1}", X, Y);
        }
    }
}

