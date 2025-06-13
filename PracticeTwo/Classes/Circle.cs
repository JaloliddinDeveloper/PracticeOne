namespace PracticeTwo.Classes
{
    internal class Circle
    {
        private double radius;
        private const double PI = 3.14159;

        public Circle()
        {
            radius = 0.0;
        }

        public Circle(double radius) =>
            this.radius = radius;

        public void SetRadius(double radius) =>
            this.radius = radius;


        public double GetRadius() =>
             radius;

        public double GetArea() =>
             PI * radius * radius;

        public double GetDiameter() =>
             radius * 2;

        public double GetCircumference() =>
             2 * PI * radius;
    }
}
