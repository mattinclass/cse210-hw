using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int usernumber = PromptUserNumber();
        int squared_number = SquareNumber(usernumber);
        DisplayResult(squared_number, username);

    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your number?: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int squared_Number = number * number;

        return squared_Number;

    }

    static void DisplayResult(int squared_Number, string name)
    {
        Console.WriteLine($"Your name is {name} and your squared number is {squared_Number}.");
    }
}