using System.Xml.Linq;

namespace TestMindbox
{
    public abstract class GeometricFigure
    {
        public abstract double getSquare();
    }

    public class Circle : GeometricFigure
    {
        private double radius;
        private double radius;
        public Circle(double radius) { this.radius = radius; }
        public override double getSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Triangle : GeometricFigure
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double getSquare()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public bool IsRectangular()
        {
            if ((Math.Pow(side1, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2)) || 
                (Math.Pow(side2, 2) == Math.Pow(side1, 2) + Math.Pow(side3, 2)) || 
                (Math.Pow(side3, 2) == Math.Pow(side2, 2) + Math.Pow(side1, 2)))
                return true;
            else
                return false;
        }
    }
}