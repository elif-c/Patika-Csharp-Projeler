using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** Interface ***");

        Fiesta fiesta = new Fiesta();
        Console.WriteLine(fiesta.BrandName().ToString());
        Console.WriteLine(fiesta.TireNumber().ToString());
        Console.WriteLine(fiesta.StandardColor().ToString());

        Civic civic = new Civic();
        Console.WriteLine(civic.BrandName().ToString());
        Console.WriteLine(civic.TireNumber().ToString());
        Console.WriteLine(civic.StandardColor().ToString());

        Console.WriteLine("*** Abstract ***");

        NewFiesta newfiesta = new NewFiesta();
        Console.WriteLine(newfiesta.BrandName().ToString());
        Console.WriteLine(newfiesta.TireNumber().ToString());
        Console.WriteLine(newfiesta.StandardColor().ToString());
    }
}
