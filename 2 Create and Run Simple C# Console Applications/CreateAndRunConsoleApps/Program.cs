using System;

Console.WriteLine("Hello, C#!");
Console.WriteLine("-----------------------------\n");


//------------------------------------------------------------------------------------------------
//Call different kinds of methods
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
//Code challenge: Implement a method of the Math class that returns the larger of two numbers
//------------------------------------------------------------------------------------------------
int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
Console.WriteLine("-----------------------------\n");


//------------------------------------------------------------------------------------------------
//Code challenge: Implement a method of the Math class that returns the larger of two numbers
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
//Code challenge: Implement a method of the Math class that returns the larger of two numbers
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
