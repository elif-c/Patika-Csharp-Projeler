using System;

// used when we need to work with indexes
// very common and increases readability of the code

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Days.Sunday);
        Console.WriteLine((int)Days.Thursday);
        Console.WriteLine((int)Days.Saturday);

        int temperature = 28;
        if (temperature < (int)Weather.Normal)
        {
            Console.WriteLine("Weather too cold");
        }
        else if (temperature > (int)Weather.Hot) 
        {
            Console.WriteLine("Weather too hot");
        }
        else if (temperature > (int)Weather.Normal && temperature < (int)Weather.TooHot)
        {
            Console.WriteLine("Let's go outside!");
        }
    }
}

enum Weather
{   
    // kept as enum data type, has to be converted
    Cold = 4,
    Normal = 15,
    Hot = 23,
    TooHot = 30
}

enum Days
{
    Monday, // the Monday member of Days enum, 0 as index, not a string
    Tuesday, // we can set the index as Monday=1
    Wednesday,
    Thursday,   // numerical data
    Friday=23,
    Saturday,
    Sunday
}