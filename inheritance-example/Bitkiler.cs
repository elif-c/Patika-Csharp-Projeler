using System;

public class Bitkiler : Canlilar
{
    protected void Fotosentez()
    {
        Console.WriteLine("Bitkiler fotosentez yapar.");
    }
}

public class TohumluBitkiler : Bitkiler
{
    public TohumluBitkiler()
    {
        // member access with constructor method 
        base.Fotosentez();
    }

    public void TohumlaCogalma()
    {
        Console.WriteLine("Tohumlu bitkiler tohumla cogalir.");
    }
}

public class TohumsuzBitkiler : Bitkiler
{
    public TohumsuzBitkiler()
    {
        base.Fotosentez();
    }
    public void TohumsuzCogalma()
    {
        Console.WriteLine("Tohumsuz bitkiler sporla cogalir");
    }
}