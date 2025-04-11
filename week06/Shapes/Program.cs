using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        //Part 5.1 Return to the Main method in Program.cs to test your code. Part5.2 Create a Square instance, call the GetColor() and GetArea() methods and make sure they return the values you expect
        Square square = new Square("black", 3);
        string sColor = square.GetColor();
        double sArea = square.GetArea();
        //Console.WriteLine($"A {sColor} square with area {sArea}");

        Rectangle rectangle = new Rectangle("blue", 2, 2);
        Circle circle = new Circle("red", 3);
        
        //Step 7.1 In your Main method, create a list to hold shapes (Hint: The data type should be List<Shape>).
        //Step 7.2 Add a square, rectangle, and circle to this list.
        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        //Step7.3 Iterate through the list of shapes. For each one, call and display the GetColor() and GetArea() methods.
        foreach (Shape shape in shapes)
        {
            Console.Write($"A {shape.GetColor()} shape with area {shape.GetArea()}\n");
        }
    }
}