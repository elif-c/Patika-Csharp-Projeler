using System.Collections;

ArrayList numbers = new ArrayList();
ArrayList primes = new ArrayList();
ArrayList nonPrimes = new ArrayList();
int counter1 = 0;
uint n;

Console.WriteLine("Please enter 20 positive numbers except 0: ");
// 0 alone is not count as an integer
while (counter1 < 20)
{
    // adding given numbers to the numbers list
    try
    {
        n = Convert.ToUInt32(Console.ReadLine());
        counter1++;
        numbers.Add(n);
    }
    catch (FormatException)
    {   
        // only numbers accepted
        Console.WriteLine("Please enter a number: ");
        continue;
    }
    catch (OverflowException)
    {   
        // no negatives accepted
        Console.WriteLine("Please enter a positive integer: ");
        continue;
    }
}

// calculating whether prime and adding number to corresponding list
// reference https://stackoverflow.com/a/65899196/20233673
foreach (uint number in numbers)
{
    int counter2 = 0;
    for (uint i = 1; i <= number; i++)
    {
        if (number == 0 || number == 1) { nonPrimes.Add(number); break; }
        if (number % i == 0) { counter2++; }
        if (counter2 > 2) { nonPrimes.Add(number); break; }
    }
    if (counter2 == 2) { primes.Add(number); }
}

uint primesTotal = 0;
primes.Sort();
primes.Reverse();
Console.WriteLine("Prime numbers: ");
foreach (uint number in primes)
{
    primesTotal += number;
    Console.WriteLine(number);
}

uint nonPrimesTotal = 0;
nonPrimes.Sort();
nonPrimes.Reverse();
Console.WriteLine("Non prime numbers: ");
foreach (uint number in nonPrimes)
{
    nonPrimesTotal += number;
    Console.WriteLine(number);
}

Console.WriteLine($"Primes list has {primes.Count} numbers, " +
    $"with an average of {primesTotal / primes.Count}.");
Console.WriteLine($"NonPrimes list has {nonPrimes.Count} numbers, " +
    $"with an average of {nonPrimesTotal / nonPrimes.Count}.");

