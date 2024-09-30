using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        // Get grade percentage
        Console.Write("What is your current percentage? ");
        double percentage = double.Parse(Console.ReadLine());
        Console.WriteLine(percentage);

        // 70% is a passing grade, report to the student if they passed or not
        string letterGrade;
        bool passed = true;
        // Get letter grade
        if (percentage >= 90) 
        {
            letterGrade = "A";
        }
        else if (percentage >= 80) 
        {
            letterGrade = "B";
        }
        else if (percentage >= 70) 
        {
            letterGrade = "C";
        }
        else if (percentage >= 60) 
        {
            letterGrade = "D";
            passed = false;
        }
        else
        {
            letterGrade = "F";
            passed = false;
        }
        // Get a '+' or '-' modifier
        if (percentage % 10 == 3 && percentage > 60)
        {
            // The grade is a minus
            letterGrade += "-";
        }
        if (percentage % 10 == 7 && percentage > 60)
        {
            // The grade is a plus
            letterGrade += "+";
        }

        Console.Write($"Your grade is {letterGrade}. ");
        if (passed) {
            Console.WriteLine("Great job skippy! So proud of you :)");
        }
        else {
            Console.WriteLine("You'll (hopefully) do better next time");
        }
    }
}