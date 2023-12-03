using AreaLibrary.Figures;
using AreaLibrary.Interfaces;

namespace AreaLibraryTests
{
    [TestFixture]
    public class IFigureTests
    {
        [TestCase]
        public void WorksWithDifferentFigures()
        {
            var figures = new List<IFigure>
            {
                new Circle(5),
                new Triangle(4, 3, 5),
                new Circle(2.5),
                new Triangle(1, 2, 1.5)
            };
            var sum = figures.Select(x => x.GetArea()).Sum();
            Assert.That(sum, Is.EqualTo(104.85).Within(10e-2));
        }
    }
}
