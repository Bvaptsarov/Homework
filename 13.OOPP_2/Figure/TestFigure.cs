using System;
using System.Linq;

namespace Figure
{
    class TestFigure
    {
        static void Main()
        {
            Circle c = new Circle(5);
            Console.WriteLine(c.CalculateSurface());

            Rectangle rec = new Rectangle(5, 4);
            Console.WriteLine(rec.CalculateSurface());

            Triangle trian = new Triangle(5, 2);
            Console.WriteLine(trian.CalculateSurface());
        }
    }
}
