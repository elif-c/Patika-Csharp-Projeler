using System;

class Program
{
    static void Main(string[] args)
    {
        Fiesta fiesta = new Fiesta();
        Console.WriteLine(fiesta.BrandName().ToString());
        Console.WriteLine(fiesta.TireNumber().ToString());
        Console.WriteLine(fiesta.StandardColor().ToString());

        Civic civic = new Civic();
        Console.WriteLine(civic.BrandName().ToString());
        Console.WriteLine(civic.TireNumber().ToString());
        Console.WriteLine(civic.StandardColor().ToString());
    }
}
