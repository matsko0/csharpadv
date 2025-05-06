namespace Task03.Domain.Models
{
    public class Triangle : Shape
    {
        private double sideA, sideB, sideC;
        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }
        public override double CalculateArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public override double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }
    }
}
