using AreaLibrary.Interfaces;


namespace AreaLibrary.Figures
{
    public class Circle: IFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius can't be less or equals zero");
            }
            Radius = radius;
        }

        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
