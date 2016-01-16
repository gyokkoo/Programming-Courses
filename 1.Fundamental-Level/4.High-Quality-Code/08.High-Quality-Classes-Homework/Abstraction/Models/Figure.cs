namespace Abstraction.Models
{
    using Interfaces;

    public abstract class Figure : IFigure
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateSurface();
    }
}