Console.WriteLine("Enter a number: ");

int number = int.Parse(Console.ReadLine());
int counter = 1;
int total = 0;

while (counter <= number)
{
    total += counter;
    counter++;
}
Console.WriteLine($"the average is {total/number}");

// char character = 'a';
// while (character < 'z')
// {
//     Console.WriteLine(character);
//     character++;
// }

Console.WriteLine("** Foreach Loop used to loop in arrays and collections **");
string[] cars = {"Lamborghini", "Volkswagen", "Volvo"};
foreach (string car in cars) // variable type depends on what's in the array
{
    Console.WriteLine(car);
}