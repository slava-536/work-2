using System.Collections.Generic;

List<string> words = new List<string>() {
    "Bella", "Alex", "John"
};
words.Add("Mike");
words.Add("Bob");
words.Add("Mario");
foreach (string name in words)
{
    Console.WriteLine("Name: " + name);
}