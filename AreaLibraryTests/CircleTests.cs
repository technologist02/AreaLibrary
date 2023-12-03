using AreaLibrary.Figures;

namespace AreaLibraryTests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(0)]
        [TestCase(-3)]
        public void InvalidRadiusCircle(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [TestCase(2.5, 19.6349)]
        [TestCase(3.12, 30.5815)]
        [TestCase(Math.PI, 31.00627)]
        public void CheckCorrectAreaCircle(double radius, double area)
        {
            var circle = new Circle(radius);
            Assert.That(circle.GetArea(), Is.EqualTo(area).Within(10e-4));
        }

        [TestCase(2, 12.5663)]
        public void CheckIntRadius(int radius, double area)
        {
            var circle = new Circle(radius);
            Assert.That(circle.GetArea(), Is.EqualTo(area).Within(10e-4));
        }
    }
}