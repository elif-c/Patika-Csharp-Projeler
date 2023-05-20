class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        // a class would set the fields to default values if
        // no explicit value is given
        // we could still call the method without setting the fields below
        rectangle.x = 5;
        rectangle.y = 8;

        Console.WriteLine(rectangle.CalculateArea());

        Rectangle_Struct rectangleStruct = new Rectangle_Struct();
        rectangleStruct.x = 3;
        rectangleStruct.y = 7;

        Console.WriteLine(rectangleStruct.CalculateArea());

        // we can create an object for a struct without the new keyword
        Rectangle_Struct rectangleStruct2;
        // a struct would not set default values to fields
        // they have to be declared
        rectangleStruct2.x = 6;
        rectangleStruct2.y = 3;

        Console.WriteLine(rectangleStruct2.CalculateArea());

    }
}

// for retaining small amounts of data, using a struct is faster than a class

class Rectangle
{
    public int x;
    public int y;

    public long CalculateArea()
    {
        return this.x * this.y;
    }
}

struct Rectangle_Struct
{
    public int x;
    public int y;

    // we cannot define a constructor without parameters inside a struct

    public long CalculateArea()
    {
        return this.x * this.y;
    }
}