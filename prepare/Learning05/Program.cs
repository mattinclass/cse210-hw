using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();


        Square mySquare = new Square("Blue", 5);
        shapes.Add(mySquare);

        Rectangle myRectangle = new Rectangle("Red", 5, 7);
        shapes.Add(myRectangle);

        Circle myCircle = new Circle("Yellow", 4);
        shapes.Add(myCircle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The shape is {color} and it has an area of {area}.");
        }
        
    }
}