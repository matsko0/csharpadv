namespace Domain.Classes
{
    public class TriangleTask3 : Shape
    {
        private double sideA, sideB, sideC;
        public TriangleTask3(double a, double b, double c)
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
