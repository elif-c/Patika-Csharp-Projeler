using System;

public class Canlilar // if sealed, other classes cannot derive from it
{
    public void Beslenme()
    {
        //Console.WriteLine("Canlilar beslenir.");
    }
    public void Solunum()
    {   
        //Console.WriteLine("Canlilar solunum yapar.");
    }
    public void Bosaltim()
    {   
        //System.Console.WriteLine("Canlilar bosaltim yapar.");
    }
    public virtual void Tepki() 
    {
        Console.WriteLine("Canlilar tepki verir.");
    }
}



