//------------------------------------------------------------------------------------------------
// Code challenge: write code to display the result of a coin flip
//------------------------------------------------------------------------------------------------
var coin = new Random();
Console.WriteLine(coin.Next(0, 2) == 0 ? "heads" : "tails");
Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Exercise - Complete a challenge activity using Boolean expressions
//------------------------------------------------------------------------------------------------
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



//------------------------------------------------------------------------------------------------
// Code challenge: update problematic code in the code editor
//------------------------------------------------------------------------------------------------
int[] numbers = [4, 8, 15, 16, 23, 42];
bool found = false;
int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
       found = true;
}

if (found) 
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Code challenge: rewrite if-elseif-else using a switch statement
//------------------------------------------------------------------------------------------------
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

type = product[0] switch
{
    "01" => "Sweat shirt",
    "02" => "T-Shirt",
    "03" => "Sweat pants",
    _ => "Other",
};

color = product[1] switch
{
    "BL" => "Black",
    "MN" => "Maroon",
    _ => "White",
};

size = product[2] switch
{
    "S" => "Small",
    "M" => "Medium",
    "L" => "Large",
    _ => "One Size Fits All",
};

Console.WriteLine($"Product: {size} {color} {type}");
Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Code challenge - implement the FizzBuzz challenge rules
for (int i = 1; i <= 100; i++)
{
    var message = $"{i}";

    if (i % 3 == 0 && i % 5 == 0)
        Console.WriteLine($"{i} - FizzBuzz");

    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");

    else 
        Console.WriteLine(i);
}
Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Role playing game battle challenge
//------------------------------------------------------------------------------------------------
Random attack = new();
int heroHealth = 10, monsterHealth = 10, damage = 0;

do
{
    damage = attack.Next(1, 11);
    monsterHealth -= damage;
    Console.WriteLine($"Monster was damaged and lost {damage} and now has {monsterHealth} health.");

    if (monsterHealth <= 0)
        break;
    
    damage = attack.Next(1, 11);
    heroHealth -= damage;
    Console.WriteLine($"Hero was damaged and lost {damage} and now has {heroHealth} health.");

} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > 0 ? "Hero wins!" : "Monster wins!");
Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Code project 1 - write code that validates integer input
//------------------------------------------------------------------------------------------------
int inputParsed = 0;
bool inputIsValid = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    var input = Console.ReadLine();
    inputIsValid = int.TryParse(input, out inputParsed);

    if (!inputIsValid)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
        continue;
    }

    if (inputParsed < 5 || inputParsed > 10)
    {
        inputIsValid = false;
        Console.WriteLine($"You entered {inputParsed}. Please enter a number between 5 and 10");
        continue;
    }
} while (!inputIsValid);

Console.WriteLine($"Your input value ({inputParsed}) has been accepted.");
Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Code project 2 - write code that validates string input
//------------------------------------------------------------------------------------------------
string? inputRole = string.Empty;
string[] roleOptions = ["administrator", "manager", "user"];
bool inputRoleIsValid = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    inputRole = Console.ReadLine();
    if (roleOptions != null && roleOptions.Contains(inputRole?.Trim().ToLower()))
        inputRoleIsValid = true;
    else
        Console.WriteLine($"The role name that you entered, \"{inputRole}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    
} while (!inputRoleIsValid);

Console.WriteLine($"Your input value ({inputRole}) has been accepted.");
Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Code project 2 - write code that validates string input
//------------------------------------------------------------------------------------------------
string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
int periodLocation = 0;
int startingLocation = 0;

foreach (var myString in myStrings)
{
    periodLocation = myString.IndexOf('.');
    var content = myString;

    while (periodLocation != -1)
    {
        var substring = content[..periodLocation].Trim();
        Console.WriteLine(substring);

        content = content.Remove(0, periodLocation + 1).Trim();
        periodLocation = content.IndexOf('.');
    }

    Console.WriteLine(content);
}

Console.WriteLine("-----------------------------\n");
