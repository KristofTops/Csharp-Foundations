using System;

Console.WriteLine("Hello, C#!");
Console.WriteLine("-----------------------------\n");


//------------------------------------------------------------------------------------------------
// Call different kinds of methods
//------------------------------------------------------------------------------------------------
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.Clear();
Console.WriteLine(roll);
Console.WriteLine(dice.Next(1, 7));
Console.WriteLine("-----------------------------\n");

Random dice2 = new Random();
int roll1 = dice2.Next();
int roll2 = dice2.Next(101);
int roll3 = dice2.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
Console.WriteLine("-----------------------------\n");


//------------------------------------------------------------------------------------------------
// Code challenge: Implement a method of the Math class that returns the larger of two numbers
//------------------------------------------------------------------------------------------------
int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
Console.WriteLine("-----------------------------\n");


//------------------------------------------------------------------------------------------------
// Random game
//------------------------------------------------------------------------------------------------
Random gameDice = new Random();

int rollDice1 = gameDice.Next(1, 7);
int rollDice2 = gameDice.Next(1, 7);
int rollDice3 = gameDice.Next(1, 7);

int total = rollDice1 + rollDice2 + rollDice3;

Console.WriteLine($"Dice roll: {rollDice1} + {rollDice2} + {rollDice3} = {total}");

if ((rollDice1 == rollDice2) || (rollDice2 == rollDice3) || (rollDice1 == rollDice3))
{
    if (rollDice1 == rollDice2 && rollDice1 == rollDice3)
    {
        Console.WriteLine("You rolled tripples! +6 bonus to total!");
        total += 6;
    } 
    else 
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }

    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >= 16)
    Console.WriteLine("You win a new car!");
else if (total >= 10)
    Console.WriteLine("You win a new laptop!");
else if (total == 7)
    Console.WriteLine("You win a trip for two!");
else
    Console.WriteLine("You win a kitten!");

Console.WriteLine("-----------------------------\n");


//------------------------------------------------------------------------------------------------
// Subscriber If Else
//------------------------------------------------------------------------------------------------
Random randomDaysUntilExpiration = new Random();
int daysUntilExpiration = randomDaysUntilExpiration.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 0) 
{
    Console.WriteLine($"Your subscription has expired.");
}
else if (daysUntilExpiration == 1) 
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!");
}
else if (daysUntilExpiration <= 5) 
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
    Console.WriteLine($"Renew now and save {discountPercentage}%.");

Console.WriteLine("-----------------------------\n");


//------------------------------------------------------------------------------------------------
// Array basics
//------------------------------------------------------------------------------------------------
var fraudulentOrderIDs = new [] { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
Console.WriteLine("-----------------------------\n");


//------------------------------------------------------------------------------------------------
// Exercise - Implement the foreach statement
//------------------------------------------------------------------------------------------------
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0, bin = 0;

foreach (int items in inventory)
{
    bin++;
    sum += items;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
Console.WriteLine("-----------------------------\n");


//------------------------------------------------------------------------------------------------
// Code challenge - Report the Order IDs that need further investigation
//------------------------------------------------------------------------------------------------
string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (var orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
        Console.WriteLine(orderID);
}

Console.WriteLine("-----------------------------\n");


//------------------------------------------------------------------------------------------------
// Code challenge - apply style guidelines to improve readability
//------------------------------------------------------------------------------------------------

/*
    Reverse a string and count the number of times a particular character appears, then print to console.
*/

int letterCount = 0;
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

foreach (char letter in message)
{ 
    if (letter == 'o') 
    { 
        letterCount++; 
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
Console.WriteLine("-----------------------------\n");
