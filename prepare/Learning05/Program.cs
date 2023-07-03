using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sq = new Square("Green", 4);
        shapes.Add(sq);

        Rectangle rc = new Rectangle("Blue", 3, 7);
        shapes.Add(rc);

        Circle cr = new Circle("White", 4);
        shapes.Add(cr);

        foreach (Shape sh in shapes)
        {
            string color = sh.GetColor();

            double area = sh.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }


    }
}