// string? readResult;
// int startIndex = 0;
// bool goodEntry = false;

// int[] numbers = { 1, 2, 3, 4, 5 };

// // Display the array to the console.
// Console.Clear();
// Console.Write("\n\rThe 'numbers' array contains: { ");
// foreach (int number in numbers)
// {
//     Console.Write($"{number} ");
// }

// // To calculate a sum of array elements, 
// //  prompt the user for the starting element number.
// Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
// while (goodEntry == false)
// {
//     readResult = Console.ReadLine();
//     goodEntry = int.TryParse(readResult, out startIndex);

//     if (startIndex > 5)
//     {
//         goodEntry = false;
//         Console.WriteLine("\n\rEnter an integer value between 1 and 5");
//     }
// }

// // Display the sum and then pause.
// Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex - 1)}");

// Console.WriteLine("press Enter to exit");
// readResult = Console.ReadLine();

// // This method returns the sum of elements n through 5
// static int SumValues(int[] numbers, int n)
// {
//     int sum = 0;
//     for (int i = n; i < numbers.Length; i++)
//     {
//         sum += numbers[i];
//     }
//     return sum;
// }


//------------------------------------------------------------------------------------------------
// Exercise
//------------------------------------------------------------------------------------------------
// bool exit = false;
// var rand = new Random();
// int num1 = 5;
// int num2 = 5;

// do
// {
//     num1 = rand.Next(1, 11);
//     num2 = num1 + rand.Next(1, 51);

// } while (exit == false);



//------------------------------------------------------------------------------------------------
// Exercise - Complete a challenge activity using the debugger
//------------------------------------------------------------------------------------------------
/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;

ChangeValue(x);

Console.WriteLine(x);

void ChangeValue(int value)
{
    value = 10;
    x = value;
}

Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Exercise - Complete a challenge activity using the debugger
//------------------------------------------------------------------------------------------------
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
    checked
    {
        smallNumber = (byte)number1;
    }
}

Console.WriteLine("-----------------------------\n");



//------------------------------------------------------------------------------------------------
// Exercise - Complete a challenge activity to catch specific exceptions
//------------------------------------------------------------------------------------------------
try
{
    try
    {
        checked
        {
            int num1 = int.MaxValue;
            int num2 = int.MaxValue;
            int result = num1 + num2;
            Console.WriteLine("Result: " + result);
        }
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
    }

    try
    {
        string str = null;
        int length = str.Length;
        Console.WriteLine("String Length: " + length);
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Error: The reference is null." + ex.Message);
    }

    try
    {
        int[] numbers = new int[5];
        numbers[5] = 10;
        Console.WriteLine("Number at index 5: " + numbers[5]);
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine("Error: Index out of range." + ex.Message);
    }

    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
}

Console.WriteLine("Exiting program.");

Console.ReadLine();
Console.WriteLine("-----------------------------\n");