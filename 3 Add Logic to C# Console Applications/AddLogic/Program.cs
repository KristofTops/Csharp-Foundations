//------------------------------------------------------------------------------------------------
// Code challenge: write code to display the result of a coin flip
//------------------------------------------------------------------------------------------------
var coin = new Random();
Console.WriteLine(coin.Next(0, 2) == 0 ? "heads" : "tails");
Console.WriteLine("-----------------------------\n");


//------------------------------------------------------------------------------------------------
// Exercise - Complete a challenge activity using Boolean expressions
//------------------------------------------------------------------------------------------------
// var userRole = string.Empty;
// var userLevel = 0;
string permission = "Admin|Manager";
int level = 60;

if (permission.ToLower().Contains("admin") && level > 55)
    Console.WriteLine("Welcome, Super Admin user.");

else if (permission.ToLower().Contains("admin") && level <= 55)
    Console.WriteLine("Welcome, Admin user.");

else if (permission.ToLower().Contains("manager") && level >= 20)
    Console.WriteLine("Contact an Admin for access.");

else if (permission.ToLower().Contains("manager") && level < 20)
    Console.WriteLine("You do not have sufficient privileges.");

else
    Console.WriteLine("You do not have sufficient privileges.");

Console.WriteLine("-----------------------------\n");