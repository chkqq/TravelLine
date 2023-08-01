namespace FindAreaAndPerimeter
{
    public class Square : IShape
    {
        private double _side;

        public double Side
        {
            get { return _side; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона квадрата может быть только положительной длинны.");
                _side = value;
            }
        }

        public Square(double side)
        {
            Side = side;
        }

        public double CalculateArea()
        {
            return Side * Side;
        }

        public double CalculatePerimeter()
        {
            return 4 * Side;
        }
    }
}
