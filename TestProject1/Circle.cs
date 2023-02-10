namespace TestProject1
{
    public class Circle : Figure
    {
        public Circle(float radius)
        {
            Area = (float)Math.PI * radius * radius;
        }
    }
}
