using System.Collections;

string sentence = Console.ReadLine();
ArrayList vowels = new ArrayList();

foreach (char i in sentence)
{
    if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
    {
        vowels.Add(i);
    }
}

vowels.Sort();
string empty = "";
foreach (char i in vowels)
{
    empty += i;
}
Console.WriteLine(empty + " -> " + empty.Length);