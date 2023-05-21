public class Hayvanlar : Canlilar
{
    protected void Adaptasyon()
    {
        Console.WriteLine("Hayvanlar adaptasyon yapar.");
    }

    public override void Tepki()
    {
        base.Tepki();
        Console.WriteLine("hayvanlar override method");
    }
}

public class Surungenler : Hayvanlar // left inherits from right
{
    public Surungenler()
    {
        base.Adaptasyon();
    }
    public void SurunmeHareketi()
    {
        Console.WriteLine("Surunme hareketi.");
    }
}

public class Kuslar : Hayvanlar
{
    public Kuslar()
    {
        base.Adaptasyon();
    }
    public void Ucmak()
    {
        Console.WriteLine("Kuslar ucar.");
    }
}