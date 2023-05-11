string[] colors = new string[5]; // defining with length

string[] animals = { "cat", "dog", "wolf", "goose" }; //defining with members

int[] array_; // defining without members or length
array_ = new int[5]; // then establishing lentgh

// appending values
colors[0] = "blue"; // appending "blue" to the index 0 of colors
array_[3] = 10;

Console.WriteLine(array_[3]);
Console.WriteLine(animals[2]);
Console.WriteLine(colors[0]);

// using loops with arrays
// program to calculate average of n amount of numbers
Console.WriteLine("Please enter array size: ");
int arrayLength = int.Parse(Console.ReadLine());
// always use exception handling while parsing in case the input is not a number
// 
int[] numbersArray = new int[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    Console.WriteLine($"Please enter {i+1}th element:");
    numbersArray[i] = int.Parse(Console.ReadLine());
}

int total = 0;
foreach (int number in numbersArray)
{
    total += number;
}
Console.WriteLine($"The average is {total/arrayLength}");