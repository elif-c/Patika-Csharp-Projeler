// recursive methods

using System.Runtime.CompilerServices;

int result = 1;
for (int i = 1; i <5; i++)
{

    result = result * 3;
}
Console.WriteLine(result);

Operations instance = new();
Console.WriteLine(instance.Expo(3, 4));

// extension methods -> need to be static
string text = "this is a text";
bool out_bool = text.CheckSpaces();
Console.WriteLine(out_bool);
if(out_bool)
{
    Console.WriteLine(text.RemoveWhiteSpaces());
}
Console.WriteLine(text.MakeUpper());
Console.WriteLine(text.MakeLower());

int[] array_ = { 4, 21, 78, 12, 35 };
array_.SortArray();
array_.Print();

int number2 = 7;
Console.WriteLine(number2.IsEvenNumber());

Console.WriteLine(text.GetFirstCharacter());

public class Operations
{
    public int Expo(int number, int expo)
    {   
        if (expo < 2)
        {
            return number;
        }
        return Expo(number, expo - 1) * number;
    }
    //
}

public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param)
    {
        string[] array = param.Split(' ');
        return string.Join("", array);
    }

    public static string MakeUpper(this string param)
    {
        string[] array = param.Split(' ');
        foreach (string i in array)
        {
            array[Array.IndexOf(array, i)] = i.ToUpper();
        }
        return string.Join(' ', array);
    }

    public static string MakeLower(this string param)
    {
        string[] array = param.Split(' ');
        foreach (string i in array)
        {
            array[Array.IndexOf(array, i)] = i.ToLower();
        }
        return string.Join(' ', array);
    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void Print(this int[] param)
    {
        foreach (int i in param)
            Console.WriteLine(i);
    }

    public static bool IsEvenNumber(this int param)
    {
        return param % 2 == 0;
    }

    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0, 1);
    }
}