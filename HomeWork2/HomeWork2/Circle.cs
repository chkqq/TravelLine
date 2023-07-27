﻿

namespace FindAreaAndPerimeter
{
    public class Circle : IShape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }

            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Радиус круга должен быть положительным");
                _radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {

            return 2 * Math.PI * Radius;

        }
    }
}
