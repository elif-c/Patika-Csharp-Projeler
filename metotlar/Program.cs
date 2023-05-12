// access (public/private) - return type - method name (parameter/arg)
    // commands;
    // return;

// only static methods can be accessed in a static class

int a = 2;
int b = 3;

int result = Sum(a, b);
Console.WriteLine(result);

Methods example = new Methods();
example.Print(Convert.ToString(result) + " printed with the instance!");

int result2 = example.Add_Sum(ref a, ref b);
Console.WriteLine(result2 + " result2 with add sum");
example.Print(Convert.ToString(result2));
example.Print(Convert.ToString(a+b));

static int Sum(int value1, int value2)
{
    return value1 + value2;
}

// if we want to access a method in another class, we need to
// create an instance of that class

class Methods
{
    public void Print(string data)
    {
        Console.WriteLine(data);
    }

    public int Add_Sum(ref int value1, ref int value2) // ref changes the variable itself
    {
        value1++;
        value2++;
        return value1 + value2;
    }
}