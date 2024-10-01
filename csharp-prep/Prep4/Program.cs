using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        Console.WriteLine("You will be asked to input multiple integer values. It will stop collecting once you enter '0'.\n");
        while (true)
        {
            Console.Write("Enter an integer value: ");
            int userNumber = int.Parse(Console.ReadLine());
            numbers.Add(userNumber);
            if (userNumber == 0) break;
        }

        // Give the sum, average, and max numbers
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The Average is: {numbers.Average()}");
        Console.WriteLine($"The Largest number is: {numbers.Max()}");
        Console.WriteLine($"The smallest positive number is:");
    }
}