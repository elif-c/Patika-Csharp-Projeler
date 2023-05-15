Console.ForegroundColor = ConsoleColor.Magenta;

string message = "this is not message1!";
string message1 = "This is message1!";

// Length
Console.WriteLine(message.Length);

// ToUpper & ToLower
Console.WriteLine(message.ToUpper());
Console.WriteLine(message.ToLower());

// Concat
Console.WriteLine(String.Concat(message, " this is concatenation!"));

// Compare, CompareTo
Console.WriteLine(message.CompareTo(message1)); // returns -1, 0 or 1 after length comparison
Console.WriteLine(String.Compare(message1, message, true)); // lexicographical
Console.WriteLine(String.Compare(message1, message, false));

// Contains, EndsWith, StartsWith
Console.WriteLine(message.Contains(message1));
Console.WriteLine(message.EndsWith("message1!"));
Console.WriteLine(message.StartsWith("message1!"));

// IndexOf
Console.WriteLine(message.IndexOf("message1!"));
Console.WriteLine(message.IndexOf("test")); // returns -1 when out of range
Console.WriteLine(message.LastIndexOf("s")); // returns last occurence of "s"

// Insert
Console.WriteLine(message.Insert(0, "Hello "));

// PadLeft, PadRight
Console.WriteLine(message + message.PadLeft(30)); // adds whitespace to the left
Console.WriteLine(message + message.PadRight(30, '*')); // adds the paddingChar

// Remove
Console.WriteLine(message.Remove(10));
Console.WriteLine(message.Remove(6, 5));
Console.WriteLine(message.Remove(0, 3));

// Replace
Console.WriteLine(message.Replace("is", "IS IT??"));
Console.WriteLine(message.Replace(" ", "*"));

// Split
Console.WriteLine(message.Split(' ')[2]);

// Substring
Console.WriteLine(message.Substring(4));
Console.WriteLine(message.Substring(4, 6)); // returns 6 characters starting from index