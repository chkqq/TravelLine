using FindAreaAndPerimeter;

namespace FindAreaAndPerimeterTest
{
    public class FindAreaAndPerimeterTest
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
    }
}