public abstract class Automobile
{
    public int TireNumber()
    {
        return 4;
    }

    public virtual Color StandardColor()
    {   
        // we write the most common one, but we can override when needed
        return Color.Black;
    }

    public abstract Brand BrandName();
}