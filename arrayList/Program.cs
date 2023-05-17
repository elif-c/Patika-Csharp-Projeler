using System.Collections;

// an array whose size is dynamically increased as required
// can contain more than one type
// System.Collections namespace

ArrayList arraylist = new ArrayList();
arraylist.Add("string value");
arraylist.Add(5);
arraylist.Add(true);
arraylist.Add('A');

// Accessing data
Console.WriteLine(arraylist[1]);
foreach (var item in arraylist)
{
    Console.WriteLine(item);
}

// AddRange - adding multiple items at once
string[] colors = { "blue", "purple", "green" };
List<int> numbers = new List<int>() {1, 6, 7, 23, 75};
arraylist.AddRange(colors);
arraylist.AddRange(numbers);

foreach (var item in arraylist)
{
    Console.WriteLine(item);
}

// Sort
arraylist.Sort(); // can't sort when there's more than 1 type

// Binary Search
arraylist.BinarySearch(7); 

// Reverse
arraylist.Reverse();
foreach (var item in arraylist)
{
    Console.WriteLine(item);
}

// Clear
arraylist.Clear();