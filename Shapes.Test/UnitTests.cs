namespace Shapes.Test
{
    public class Tests
    {
        Circle circle1, circle2;
        Triangle triangle1, triangle2;
        Rectangle rectangle;

        [SetUp]
        public void Setup()
        {
            circle1 = new Circle(15);
            circle2 = new Circle(1);
            triangle1 = new Triangle(3, 4, 5);
            triangle2 = new Triangle(1, 1, 1);
            rectangle = new Rectangle(3, 4);
        }

        [Test]
        public void TestCircleSquare()
        {
            Assert.That(circle1.GetSquare(), Is.EqualTo(Math.PI * 15 * 15));
            Assert.That(circle2.GetSquare(), Is.EqualTo(Math.PI));
        }

        [Test]
        public void TestTriangleSquare()
        {
            Assert.Multiple(() =>
            {
                Assert.That(triangle1.GetSquare(), Is.EqualTo(6));
                Assert.That(triangle2.GetSquare(), Is.EqualTo(Math.Sqrt(3) / 4));
            });
        }

        [Test]
        public void TestTriangleIsRectangular()
        {
            Assert.That(triangle1.IsRectangular(), Is.True);
            Assert.False(triangle2.IsRectangular());
        }

        public class Rectangle : IShape
        {
            double a, b;
            public Rectangle(double a, double b)
            {
                (this.a, this.b) = (a, b);
            }
            public double GetSquare() => a * b;
        }

        [Test]
        public void TestRectangleSquare()
        {
            Assert.That(rectangle.GetSquare(), Is.EqualTo(12));
        }

        [Test]
        public void TestIShapeSquare()
        {
            IShape shape = rectangle;
            Assert.That(shape.GetSquare(), Is.EqualTo(12));
        }
    }
}