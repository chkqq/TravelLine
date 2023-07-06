using ConsoleApp1;

namespace FindArrayAndPerimeterTest
{
    public class FindArrayAndPerimeterTests
    {

        [Test]
        public void Circle_CalculateAreaAndPerimeter_ExpectedResult()
        {
            var circle = new Circle(5);

            circle.CalculateArea();
            circle.CalculatePerimeter();

            Assert.AreEqual(25 * Math.PI, circle.CalculateArea());
            Assert.AreEqual(10 * Math.PI, circle.CalculatePerimeter());
        }

        [Test]
        public void Square_CalculateAreaAndPerimeter_ExpectedResult()
        {
            var square = new Square(5);

            square.CalculateArea();
            square.CalculatePerimeter();

            Assert.AreEqual(25, square.CalculateArea());
            Assert.AreEqual(20, square.CalculatePerimeter());
        }

        [Test]

        public void Triangle_CalculateAreaAndPerimeter_ExpectedResult()
        {
            var triangle = new Triangle(5, 3, 4);

            triangle.CalculateArea();
            triangle.CalculatePerimeter();

            Assert.AreEqual(6, triangle.CalculateArea());
            Assert.AreEqual(12, triangle.CalculatePerimeter());
        }
    }
}