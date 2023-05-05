using System;

try
{
    Console.WriteLine("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
}
catch(Exception ex)
{
    Console.WriteLine("Error: " + ex.Message.ToString());
}
finally 
{
    Console.WriteLine("Bye ^^");
}