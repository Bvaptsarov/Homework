using System;
using System.Linq;

namespace Figure
{
    public class Circle : Shape
    {
        public Circle(double rad) : base(rad, rad) { }

        public override double CalculateSurface()
        {
            return Math.PI * (Height*Width);
        }
    }
}
