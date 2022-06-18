// See https://aka.ms/new-console-template for more information

// Declare variables and then initialize to zero.
int num1 = 0; int num2 = 0;

// Display title as the C# console calculator app.
Console.WriteLine("Welcome to Console Calculator in C#!\r");
Console.WriteLine("----------------------------------------------------------------------------\n");
Console.WriteLine("This program will take 2 seperate numbers and perform the chosen math function");

// Ask the user to type the first number.
Console.WriteLine("Please enter the first number, and then press Enter");
num1 = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number.
Console.WriteLine("Please enter the second number, and then press Enter");
num2 = Convert.ToInt32(Console.ReadLine());

// Ask the user to choose an option.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("\tr - Remainder");
Console.WriteLine("\tp - Power");
Console.Write("Your option? ");

// Use a switch statement to do the math.
switch (Console.ReadLine())
{
    case "a":
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
    case "r":
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"Your result: {num1} % {num2} = " + (num1 % num2));
        break;
    case "p":
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"Your result: {num1} to the power of {num2} = " + Math.Pow(num1,num2));
        break;
    default:
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Invalid Choice, please enter a character from the following --- a, s, m, d, r, p");
        break;
}
// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app");
Console.ReadKey();
