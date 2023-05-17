// List<T> class
// System.Collections.Generic
// T-> object type

List<int> numberList = new List<int>;
numberList.Add(0);
numberList.Add(780); 
numberList.Add(29);

List<string> stringList= new List<string>();
stringList.Add("blue");

// Count
Console.WriteLine(numberList.Count);
Console.WriteLine(stringList.Count);

// Accessing items
foreach (int number in numberList)
{
    Console.WriteLine(number);
}

numberList.ForEach(number => Console.WriteLine(number));

// Removing items from list
numberList.Remove(0);
numberList.RemoveAt(1);

// Searching in list
if (numberList.Contains(780))
{
    Console.WriteLine("contains");
}

// Accessing index with item
Console.WriteLine(stringList.BinarySearch("blue"));

// Converting array to list
string[] animals = { "dog", "cat", "cheetah" };
List<string> animalsList = new List<string>(animals);

// Clearing list
animalsList.Clear();

// Holding object in list
List<Users> usersList = new List<Users>();
Users user1 = new Users();
user1.Name = "Jim";
user1.Surname = "Halpert";
user1.Age = 28;

usersList.Add(user1);

List<Users> newList = new List<Users>();
newList.Add(new Users()
{
    Name="Dwight",
    Surname="Schrute",
    Age=28,
})

foreach (Users user in usersList)
{
    Console.WriteLine("User name: " + user.Name);
    Console.WriteLine("User surname: " + user.Surname);
    Console.WriteLine("User age: " + user.Age);
}



public class Users
{
    private string names;
    private string surnames;
    private int ages;

    public string Name {  get => name; set => name = value; } // encapsulating variables
    public string Surname { get => surname; set => surname = value; }
    public int Age { get => ages; set => ages = value; }
}