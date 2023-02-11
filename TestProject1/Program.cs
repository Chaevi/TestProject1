using TestProject1;

Figure figure = new Circle(5);
Rectangle rectangle1 = new Rectangle(2);
Rectangle rectangle2 = new Rectangle(2,4);
Triangle triangle = new Triangle(3, 4, 5);

Console.WriteLine("Circle: " + figure.GetArea());
Console.WriteLine("Rect1: " + rectangle1.GetArea());
Console.WriteLine("Rect2: " + rectangle2.GetArea());
Console.WriteLine("Triangle: " + triangle.GetArea());
Console.WriteLine("rect1: " + rectangle1.GetArea());
