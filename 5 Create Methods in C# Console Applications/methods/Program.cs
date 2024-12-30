//------------------------------------------------------------------------------------------------
// Identify duplicated code
//------------------------------------------------------------------------------------------------
using System;

int[] times = [800, 1200, 1600, 2000];
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

/* Format and display medicine times */
DisplayMediceTimes();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    AdjustTimes(diff);
}
else
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    AdjustTimes(diff);
}

Console.WriteLine("New Medicine Schedule:");

/* Format and display medicine times */
DisplayMediceTimes();

void DisplayMediceTimes()
{
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }

    Console.WriteLine();
}

void AdjustTimes(int diff)
{
    for (int i = 0; i < times.Length; i++)
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Valid IP's
//------------------------------------------------------------------------------------------------
string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
        Console.WriteLine($"{ip} is a valid IPv4 address");
    else
        Console.WriteLine($"{ip} is an invalid IPv4 address");
}

void ValidateLength()
{
    validLength = address.Length == 4;
};

void ValidateZeroes()
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
            validZeroes = false;
    }

    validZeroes = true;
}

void ValidateRange()
{
    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }

    validRange = true;
}

Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Exercise - Complete the challenge to create a reusable method
//------------------------------------------------------------------------------------------------
Random random = new Random();

string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

PredictFortune();

void PredictFortune()
{
    int luck = random.Next(100);
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));

    Console.WriteLine("A fortune teller whispers the following words:");

    for (int i = 0; i < 4; i++)
        Console.Write($"{text[i]} {fortune[i]} ");
}

Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Exercise - Use parameters in methods
//------------------------------------------------------------------------------------------------
int[] schedule = { 800, 1200, 1600, 2000 };

DisplayAdjustedTimes(schedule, 6, -6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}

Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Exercise - Understand method scope
//------------------------------------------------------------------------------------------------
double pi = 3.14159;

PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius) 
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Exercise - Complete the challenge to display email addresses
//------------------------------------------------------------------------------------------------
string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    PrintEmails(corporate[i, 0], corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    PrintEmails(external[i, 0], external[i, 1], externalDomain);
}

void PrintEmails(string firstName, string lastName, string domain = "contoso.com") 
{
    var email = $"{firstName[..2]}{lastName}@{domain}".ToLower();
    Console.WriteLine(email);
}