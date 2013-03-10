using System;
using System.Linq;

namespace Figure
{
    public class Triangle : Shape
    {
        public Triangle(double side, double height)
            : base(side, height)
        {
        }

        public override double CalculateSurface()
        {
            return Width * Height * 0.5; //from base class
        }
    }
}
