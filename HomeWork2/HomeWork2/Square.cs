namespace FindAreaAndPerimeter
{
    public class Square : IShape
    {
        private double _side;

        public Square(double side)
        {
            _side = side;
        }

        public double CalculateArea()
        {
            double area = _side * _side;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = _side * 4;
            return perimeter;
        }
    }
}
