namespace TestProject1
{
    public class Triangle : Figure
    {
        public Triangle(float a, float b, float c)
        {
            if (a * a == b * b + c * c)
            {
                Area = b * c / 2;
                return;
            }
            if (b * b == a * a + c * c)
            {
                Area = a * c / 2;
                return;
            }
            if (c * c == a * a + b * b)
            {
                Area = a * b / 2;
                return;
            }

            // S = √(p·(p - a)·(p - b)·(p - c)), P = (a+b+c)/2
            float P = (a + b + c) / 2;
            Area = (float)Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        }

    }
}
