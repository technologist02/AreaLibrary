using AreaLibrary.CustomExceptions;
using AreaLibrary.Figures;

namespace AreaLibraryTests
{
    [TestFixture]
    public class TriangleTests
    {       
        [TestCase(5, 2, 1)]
        [TestCase(1, 2, 3)]
        public void InvalidTriangleSides(double sideA, double sideB, double sideC)
        {
            Assert.Throws<NotFigureException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestCase(3, 4, 5, 6)]
        [TestCase(5, 3, 4, 6)]
        public void CheckIsRightTriangle(double sideA, double sideB, double sideC, double Area)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            Assert.Multiple(() =>
            {
                Assert.That(triangle.IsRightTriangle, Is.True);
                Assert.That(triangle.GetArea(), Is.EqualTo(Area));
            });
        }

        [TestCase(6, 7, 8, 20.333)]
        [TestCase(5, 5, 5, 10.825)]
        public void CheckCorrectAreaTriangle(double sideA, double sideB, double sideC, double Area)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            Assert.That(triangle.GetArea(), Is.EqualTo(Area).Within(10e-3));
        }

    }
}
