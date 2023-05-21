public class Civic : IAutomobile
{
    public int TireNumber()
    {
        return 4;
    }

    public Brand BrandName()
    {
        return Brand.Honda;
    }

    public Color StandardColor()
    {
        return Color.Black;
    }
}