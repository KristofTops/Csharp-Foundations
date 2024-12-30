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
double totalA = 0;

foreach (var item in values)
{
    if(double.TryParse(item, out double parsedItem))
        totalA += parsedItem;
    else
        message += item;
}

Console.WriteLine("Message: {0}", message);
Console.WriteLine("Total: {0}", totalA);



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



//------------------------------------------------------------------------------------------------
// Exercise - Explore string interpolation
//------------------------------------------------------------------------------------------------
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");
Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Exercise - Complete a challenge to apply string interpolation to a form letter
//------------------------------------------------------------------------------------------------
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string currentReturnFormatted = $"{currentReturn:P2}";
string currentProfitFormatted = $"{currentProfit:C2}";

string newReturnFormatted = $"{newReturn:P2}";
string newProfitFormatted = $"{newProfit:C2}";

Console.WriteLine($"");
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine($"Currently, you own {currentShares} shares at a return of {currentReturn:P2}.");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C2}.");

Console.WriteLine("Here's a quick comparison:\n");
Console.WriteLine($"{currentProduct.PadRight(20)} {currentReturnFormatted} {currentProfitFormatted.PadLeft(17)}");
Console.WriteLine($"{newProduct.PadRight(20)} {newReturnFormatted} {newProfitFormatted.PadLeft(17)}");
Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Exercise - Complete a challenge to extract, replace, and remove data from an input string
//------------------------------------------------------------------------------------------------
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

string spanOpen = "<span>", spanClose = "</span>";
string divOpen = "<div>", divClose = "</div";
int quantityStartPosition = input.IndexOf(spanOpen) + spanOpen.Length;
int quantityEndPosition = input.IndexOf(spanClose);

int outputStartPosition = input.IndexOf(divOpen) + divOpen.Length;
int outputEndPosition = input.IndexOf(divClose);

quantity = input.Substring(quantityStartPosition, quantityEndPosition - quantityStartPosition);
output = input.Substring(outputStartPosition, outputEndPosition - outputStartPosition)
              .Replace("&trade;", "&reg");

Console.WriteLine($"quantity: {quantity}");
Console.WriteLine($"output: {output}");
Console.WriteLine("-----------------------------\n");