namespace FindAreaAndPerimeter
{
    public class Triangle : IShape
    {
        private double _side1;
        private double _side2;
        private double _side3;
        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double CalculateArea()
        {

            double semiPerimeter = (_side1 + _side2 + _side3) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - _side1) * (semiPerimeter - _side2) * (semiPerimeter - _side3));
            return area;
        }

        public double CalculatePerimeter()
        {

            double perimeter = _side1 + _side2 + _side3;
            return perimeter;
        }
    }
}
