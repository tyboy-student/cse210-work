using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        bool continueLoop = true;
        Random rng = new Random();
        int magicNumber;
        magicNumber = rng.Next(100);
        int userGuess;

        while (true)
        {
            Console.Write("Guess the Magic Number: ");
            userGuess = int.Parse(Console.ReadLine());
            if (userGuess == magicNumber)
            {
                // leave the loop if the number is correct
                break;
            }            
            // Assume we didn't break the loop
            Console.WriteLine("Not Quite");
            if (userGuess < magicNumber) Console.WriteLine("You need to go higher");
            else Console.WriteLine("You need to go lower");
        }
        Console.WriteLine("Correct!");
        // Wait on the user to hit enter to close the program
        Console.Write("Press ENTER to end program");
        Console.ReadLine();
    }
}