using System;
/**
* @author Talha Naseer
* Class: CS201
* Program Description: The Program.cs file contains the main program, which tests 
* the Rectangle class. It creates rectangles, sets their dimensions,
* and checks if negative values are handled correctly.
*/

class Program
{
    public static void Main()
    {
        // Create a new Rectangle object named aRectangle
        // with a length of 3 and a width of 4.
        Rectangle aRectangle = new Rectangle(3, 4);

        // Display the rectangle dimensions
        Console.WriteLine($"Length: {aRectangle.Length}, " +
                          $"Width: {aRectangle.Width}");

        // Test that negative values are ignored
        aRectangle.Length = -2;
        aRectangle.Width = -4;
        Console.WriteLine($"Length: {aRectangle.Length}, " +
                          $"Width: {aRectangle.Width}");

        // Create a new Rectangle object named badRectangle
        // with a length of -3 and a width of -4.
        Rectangle badRectangle = new Rectangle(-3, -4);

        // Display the rectangle dimensions
        Console.WriteLine($"\nLength: {badRectangle.Length}, " +
                          $"Width: {badRectangle.Width}");

        // Test that valid values may be set
        aRectangle.Length = 2;
        aRectangle.Width = 4;
        Console.WriteLine($"Length: {aRectangle.Length}, " +
                          $"Width: {aRectangle.Width}");
    } // end Main
} // end class Program
