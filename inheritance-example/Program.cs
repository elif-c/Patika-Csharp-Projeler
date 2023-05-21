class Program
{
    static void Main(string[] args)
    {
        TohumsuzBitkiler tohumsuzbitki = new TohumsuzBitkiler();
        tohumsuzbitki.Beslenme();
        tohumsuzbitki.Solunum();
        tohumsuzbitki.Bosaltim();
        tohumsuzbitki.TohumsuzCogalma();
        // tohumsuzbitki.Fotosentez(); when we access the function
        // above, we access this method as well because we included
        // a base statement

        Kuslar marti = new Kuslar();
        marti.Beslenme();
        marti.Solunum();
        marti.Ucmak();
    }
}