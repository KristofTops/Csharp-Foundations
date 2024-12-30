using System.Globalization;

//------------------------------------------------------------------------------------------------
// Choose the correct data types
//------------------------------------------------------------------------------------------------

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte\t: {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short\t: {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int\t: {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long\t: {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");
Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
Console.WriteLine("-----------------------------\n");


//------------------------------------------------------------------------------------------------
// Exercise - Complete a challenge to combine string array values as strings and as integers
//------------------------------------------------------------------------------------------------
var originalCulture = CultureInfo.CurrentCulture;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

string[] values = ["12.3", "45", "ABC", "11", "DEF"];
string message = string.Empty;
double total = 0;

foreach (var item in values)
{
    if(double.TryParse(item, out double parsedItem))
        total += parsedItem;
    else
        message += item;
}

Console.WriteLine("Message: {0}", message);
Console.WriteLine("Total: {0}", total);



//------------------------------------------------------------------------------------------------
// Exercise - Complete a challenge to output math operations as specific number types
//------------------------------------------------------------------------------------------------
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

var result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

var result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

var result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

CultureInfo.CurrentCulture = originalCulture;
Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Exercise - Complete a challenge to reverse words in a sentence
//------------------------------------------------------------------------------------------------
string pangram = "The quick brown fox jumps over the lazy dog";
string[] splitPangram = pangram.Split(' ');
string[] splitPangramReversed = new string[splitPangram.Length];
var reversedPangram = string.Empty;

for (int i = 0; i < splitPangram.Length; i++)
{
    splitPangramReversed[i] = string.Join("", splitPangram[i].Reverse());
}

reversedPangram = string.Join(' ', splitPangramReversed);
Console.WriteLine(reversedPangram);
Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors
//------------------------------------------------------------------------------------------------
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(',');
Array.Sort(orders);

foreach (var order in orders)
    Console.WriteLine(order.Length == 4 ? $"{order}": $"{order} \t- Error");

Console.WriteLine("-----------------------------\n");
