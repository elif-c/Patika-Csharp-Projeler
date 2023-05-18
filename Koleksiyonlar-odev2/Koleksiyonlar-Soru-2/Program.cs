int[] numbers = new int[20];

for (int i = 0; i < numbers.Length; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    numbers[i] = number;
}
foreach (int number in numbers) { Console.WriteLine(number); }

int[] min = new int[3];
int[] max = new int[3];

Array.Sort(numbers);
for (int i = 0; i < 3; i++)
{
    // getting smallest 3 numbers
    min[i] = numbers[i];
}

Array.Reverse(numbers);
for (int i = 0; i < 3; i++)
{
    // getting biggest 3 numbers
    max[i] = numbers[i];
}

int minTotal = 0;
int maxTotal = 0;

foreach (int number in min) { minTotal += number; }
foreach (int number in max) { maxTotal += number; }

int total = (minTotal / min.Length) + (maxTotal / max.Length);
Console.WriteLine($"Min numbers average at {minTotal / min.Length}.");
Console.WriteLine($"Max numbers average at {maxTotal / max.Length}.");
Console.WriteLine($"The total is: {total}.");