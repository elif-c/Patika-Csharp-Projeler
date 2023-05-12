// out parameters

string number = "999";

bool result = int.TryParse(number, out int outnumber);
if (result)
    Console.WriteLine("successful parse " + outnumber);
else
{
    Console.WriteLine("unsuccessful parse");
}

Metotlar instance = new Metotlar();
instance.Sum(4, 5, out int totalSum);
Console.WriteLine(totalSum);

// method overloading
int expression = 999;
instance.Print(Convert.ToString(expression));
instance.Print(expression);

// method signature
// method name + parameter number + parameter
instance.Print("hey", " there");

class Metotlar
{
    public void Sum(int a, int b, out int sum)
    {
        sum = a + b;
    }

    public void Print(string data)
    {
        Console.WriteLine(data);
    }

    public void Print(int data)
    {
        Console.WriteLine(data);
    }

    public void Print(string data, string data2)
    {
        Console.WriteLine(data + data2);
    }
}