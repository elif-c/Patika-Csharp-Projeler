using System;

namespace console_programlama
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("isim");
            string name = Console.ReadLine();
            Console.WriteLine("soyisim");
            string surname = Console.ReadLine();
            Console.WriteLine("Hello, " + name + " " + surname);
            Console.ReadKey();
        }
    }
}