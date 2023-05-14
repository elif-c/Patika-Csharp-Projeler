Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("** 1 **");
Console.WriteLine("Please enter a positive number: ");
string console = Console.ReadLine();
int pos_number;
bool success = int.TryParse(console, out pos_number);
if (success)
{
    int[] number_array = new int[pos_number];
    Console.WriteLine($"Please enter {pos_number} numbers separated by spaces: ");
    string[] str_array = Console.ReadLine().Split(' ');
    foreach (string i in str_array)
    {
        if (i != null) {
            int j = int.Parse(i);
            if (j % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
else
{
    Console.WriteLine($"Attempted conversion of '{console ?? "<null>"}' failed.");
}

Console.WriteLine("** 2 **");

Console.WriteLine("Please enter two positive numbers separated by spaces: ");
string[] array1 = Console.ReadLine().Split(' ');
int n = int.Parse(array1[0]);
int m = int.Parse(array1[1]);
Console.WriteLine($"Please enter {n} positive numbers separated by spaces: ");
string[] array2 = Console.ReadLine().Split(' ');
foreach (string i in array2)
{
    int i_int = int.Parse(i);
    if ((i_int == m) || (i_int % m == 0)) 
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("** 3 **");
Console.WriteLine("Please enter a positive number: ");
string console4 = Console.ReadLine();
Console.WriteLine($"Please enter {int.Parse(console4)} words separated by spaces: ");
string[] array3 = Console.ReadLine().Split(' ');
Array.Reverse(array3);
foreach (string s in array3) {
    Console.WriteLine(s);
}



Console.WriteLine("** 4 **");
Console.WriteLine("Please write a sentence: ");
string[] words_array = (Console.ReadLine()).Split(' ');
int counter = 0;
foreach (string word in words_array)
{
    counter += word.Length;
}
Console.WriteLine($"There are {words_array.Length} words and {counter} letters in that sentence.");
