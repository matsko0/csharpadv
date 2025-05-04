namespace Domain.Classes
{
    public class CircleTask3 : Shape
    {
        private double radius;
        public CircleTask3(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
