using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int numberToSquare)
    {
        return numberToSquare * numberToSquare;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"User Name: {userName}");
        Console.WriteLine($"Squared Number: {squaredNumber}");
    }
}