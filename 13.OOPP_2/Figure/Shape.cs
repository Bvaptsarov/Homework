using System;

using System.Linq;

namespace Figure
{
    public abstract class Shape
    {
        private Double width;
        private Double height;

        public Double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value > 0)
                    this.height = value;
                else
                    throw new ArgumentException("Width cannot be negative value");
            }
        }

        public Double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value > 0)
                    this.width = value;
                else
                    throw new ArgumentException("Width cannot be negative value");
            }
        }

        public Shape(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Width and height cannot be negative or zero");
            }
            else
            {
                Width = width;
                Height = height;
            }
        }
        
        public abstract double CalculateSurface();

    }
}
