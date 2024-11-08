using System;

class Program
{
    static void Main(string[] args)
    {   
        //CORE REQUIREMENT #1 AND #2

        // Console.Write("What is your grade percentage? ");
        // string stringGradePercentage = Console.ReadLine();
        // int numberGradePercentage = int.Parse(stringGradePercentage);

        // if (numberGradePercentage >= 90)
        // {
        //     Console.WriteLine("Your grade is A.");
        // }
        // else if (numberGradePercentage >= 80)
        // {
        //     Console.WriteLine("Your grade is B.");
        // }
        // else if (numberGradePercentage >= 70)
        // {
        //     Console.WriteLine("Your grade is C.");
        // }
        // else if (numberGradePercentage >= 60)
        // {
        //     Console.WriteLine("Your grade is D.");
        // }
        // else
        // {
        //     Console.WriteLine("Your grade is F.");
        // }

        // if (numberGradePercentage >= 70)
        // {
        //     Console.WriteLine("Congratulations, you have passed the course!");
        // }
        // else
        // {
        //     Console.WriteLine("Unfortunately, you didn't pass the course this time, but don't be discouraged. Use this as an opportunity to learn and try again—you can do it!");
        // }

        //CORE REQUIREMENT #3
        Console.Write("What is your grade percentage? ");
        string stringGradePercentage = Console.ReadLine();
        int numberGradePercentage = int.Parse(stringGradePercentage);

        string gradeLetter = "";

        if (numberGradePercentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (numberGradePercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (numberGradePercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (numberGradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }
        
        Console.WriteLine($"Your grade is: {gradeLetter}.");

        if (numberGradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the course!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you didn't pass the course this time, but don't be discouraged. Use this as an opportunity to learn and try again—you can do it!");
        }
    }
}