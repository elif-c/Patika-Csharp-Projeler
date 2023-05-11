int[] numberArray = { 11, 24, 5, 17, 8, 12, 3, 28 };

//sort
Console.WriteLine("** Unsorted Array **");
print(numberArray);

Console.WriteLine("** Sorted Array **");
Array.Sort(numberArray);
print(numberArray);

// clear
Console.WriteLine("** Array Clear **");
Array.Clear(numberArray, 2, 2);
print(numberArray);

// reverse
Console.WriteLine("** Array Reverse **");
Array.Reverse(numberArray);
print(numberArray);

// indexof
Console.WriteLine("** Array IndexOf **");
Console.WriteLine(Array.IndexOf(numberArray, 24));

// resize
Console.WriteLine("** Array Resize **");
Array.Resize<int>(ref numberArray, 9);
numberArray[8] = 99;
print(numberArray);

static void print(int[] numberArray)
{
    foreach (var number in numberArray)
        Console.WriteLine(number);
}