public class Fiesta : IAutomobile
{
    public int TireNumber()
    {
        return 4;
    }

    public Brand BrandName()
    {
        return Brand.Ford;
    }

    public Color StandardColor()
    {
        return Color.Red;
    }
}