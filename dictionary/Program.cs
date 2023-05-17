// key & pair
// System.Collections 
using System.Collections;

Dictionary<int, string> users = new Dictionary<int, string>();

users.Add(1, "Victoria");
users.Add(2, "David");
users.Add(3, "Thomas");
users.Add(4, "Anya");

// Accessing dictionary items
Console.WriteLine(users[4]);
foreach  (var user in users)
{
    Console.WriteLine(user);
}

// Count
Console.WriteLine(users.Count);

// Contains
Console.WriteLine(users.ContainsKey(12));
Console.WriteLine(users.ContainsValue("Anya"));

// Remove
users.Remove(3);

// Keys, Values
foreach (var user in users.Keys)
{
    Console.WriteLine(user);
}
foreach (var user in users.Values)
{
    Console.WriteLine(user);
}
