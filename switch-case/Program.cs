using System;

int month = DateTime.Now.Month;

switch (month)
{
    case 1:
        Console.WriteLine("January");
        break;
    case 2:
        Console.WriteLine("February");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    default:
        Console.WriteLine("Wrong input");
    break;
}

switch (month)
{
    case 3:
    case 4:
    case 5:
        Console.WriteLine("It's spring time!");
        break;
    break;
}
