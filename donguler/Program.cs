using System;
using System.ComponentModel.Design;

Console.Write("Enter a number: ");
int timer = int.Parse(Console.ReadLine());

for (int i = 1; i <= timer; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

int odd_total = 0;
int even_total = 0;
for (int i = 1;i <= 1000; i++)
{
    if ((i % 2) == 1) 
        odd_total += i; 
    else
        even_total += i;
}
Console.WriteLine($"Odd total equals = {odd_total}");
Console.WriteLine($"Even total equals = {even_total}");

for (int i = 0; i < 10; i++)
{
    if (i == 4)
        continue;
    Console.WriteLine(i);
}

for (int i = 0;i < 10; i++)
{
    if (i == 7)
        break;
    Console.WriteLine(i);
}