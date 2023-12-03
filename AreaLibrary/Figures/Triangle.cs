using AreaLibrary.CustomExceptions;
using AreaLibrary.Interfaces;


namespace AreaLibrary.Figures
{
    public class Triangle : IFigure
    {
        public double SideA { get;}
        public double SideB { get;}
        public double SideC { get;}

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("sides of triangle can't less or equals zero");
            }
            if (!IsTriangle(sideA, sideB, sideC))
            {
                throw new NotFigureException("Impossible to create a triangle");
            }
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public bool IsRightTriangle()
        {
            return SideA * SideA + SideB * SideB == SideC * SideC || SideA * SideA + SideC * SideC == SideB * SideB || SideB * SideB + SideC * SideC == SideA * SideA;
        }

        public double GetArea()
        {
            var p = (SideA + SideB + SideC)/2;
            var area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return area;
        }

        private static bool IsTriangle(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }
    }
}
