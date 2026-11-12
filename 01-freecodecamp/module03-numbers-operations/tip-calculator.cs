// MS Learn Day 3 / Exercise 1 — Tip calculator
// Collect the bill amount and tip percentage
Console.WriteLine("Write your bil");
Console.Write("Write your amount: ");
decimal amount = Convert.ToDecimal(Console.ReadLine());
Console.Write("Write precent: ");
decimal precent = Convert.ToDecimal(Console.ReadLine());
// Display the entered values
Console.WriteLine("Your bil:");
Console.WriteLine($"Your amount is {amount}!");
Console.WriteLine($"Your present is {precent}!");
// Calculate the tip and total
decimal tipAmount = amount * (precent / 100);
decimal totalAmount = amount + tipAmount;
// Display the results
Console.WriteLine($"The tip is {tipAmount}");
Console.WriteLine($"the total is (tot)alAmount");
