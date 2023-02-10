namespace TestProject1
{
    public class Rectangle : Figure
    {
        public Rectangle(float a) // Если квадрат
        {
            Area = a * a;
        }

        public Rectangle(float a, float b) // Если прямоугольник
        {
            Area = a * b;
        }
    }
}
