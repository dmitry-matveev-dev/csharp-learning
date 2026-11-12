// MS Learn Day 1 / Exercise 2 — Name and age
// Ask for the user's name
Console.Write("Wats your name: ");
string name = Console.ReadLine();
// Ask for the user's age
Console.Write("How old are you: ");
int age = int.Parse(Console.ReadLine());
// Display a personalized message that includes both pieces of information
Console.WriteLine($"Hello {name} your age is {age}!");
