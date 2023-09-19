/**
* @author Talha Naseer
* Class: CS201
* Program Description: he Rectangle.cs file defines the Rectangle class. 
* It ensures that the length and width properties are non-negative, 
* providing a basic structure for representing rectangles in applications.
*/

class Rectangle
{
    private double length;
    private double width;

    // Constructor that sets the length and width
    public Rectangle(double initialLength, double initialWidth)
    {
        // Ensure non-negative values are set
        this.Length = Math.Max(0, initialLength);
        this.Width = Math.Max(0, initialWidth);
    }

    // Property for Length with validation
    public double Length
    {
        get { return length; }
        set { length = Math.Max(0, value); }
    }

    // Property for Width with validation
    public double Width
    {
        get { return width; }
        set { width = Math.Max(0, value); }
    }
} // end class Rectangle
