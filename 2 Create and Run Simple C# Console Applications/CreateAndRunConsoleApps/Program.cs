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