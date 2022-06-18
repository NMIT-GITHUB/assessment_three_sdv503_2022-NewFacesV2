// See https://aka.ms/new-console-template for more information

// Declare the two variables for the numbers and set to value of 0
int num1 = 0; int num2 = 0;

// Writelines for the calculator and explaining what it will do.
Console.WriteLine("Welcome to Console Calculator in C#!\r");
Console.WriteLine("----------------------------------------------------------------------------\n");
Console.WriteLine("This program will take 2 seperate numbers and perform the chosen math function");


Console.WriteLine("Please enter the first number, and then press Enter");

// Setting value to num1 to the value entered by user
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number, and then press Enter");

// Setting value to num2 to the second value entered
num2 = Convert.ToInt32(Console.ReadLine());

// Writelines to display each mathematical operator choice, using \t for neat indentation, I assigned a letter to each mathematical operator.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("\tr - Remainder");
Console.WriteLine("\tp - Power");
Console.Write("Your option? ");

/* Switch containing each math operator as a seperate case, with different background and foreground for each one.
The default switch is for cases where a letter not on the list is pressed.
*/
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
// After the math is performed it will ask for any key to be pressed, Console.ReadKey() not asking for a particular key, will perform when any key is pressed.
Console.Write("Press any key to close the Calculator console app");
Console.ReadKey();
