

namespace FindAreaAndPerimeter
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {

            double area = Math.PI * _radius * _radius;
            return area;

        }

        public double CalculatePerimeter()
        {

            double perimiter = 2 * Math.PI * _radius;
            return perimiter;

        }
    }
}
