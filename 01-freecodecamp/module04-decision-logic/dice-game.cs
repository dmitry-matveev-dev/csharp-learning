// MS Learn Day 4 / Exercise 1 — Dice game with bonuses
// Roll the dice
Random num = new Random();

int roll1 = num.Next(1, 7);
int roll2 = num.Next(1, 7);
int roll3 = num.Next(1, 7);
int total = roll1 + roll2 + roll3;
// Display the roll and total
Console.WriteLine($"{roll1} + {roll2} + {roll3} = {total}");
// Award a bonus for doubles or triples
if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3)){
    if ((roll1 == roll2) && (roll2 == roll3)){
        Console.WriteLine("You win tripple!");
        total *= 3;}
    else {
        Console.WriteLine($"You win double!");
        total *= 2;}
}
else {
    Console.WriteLine("You have not bonus!");}
// Display the final result
if (total >= 16){
    Console.WriteLine("You win car!");}
else if (total >= 10){
    Console.WriteLine("You win mobile!");}
else if (total >= 7){
    Console.WriteLine("You win hat!");}
else {
    Console.WriteLine("You win kitten!");}
