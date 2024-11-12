using System;

class Program
{
    static void Main(string[] args)
    {
        //CORE REQUIREMENT #1

        // Console.Write("What is the magic number? ");
        // string answerMagicNumber = Console.ReadLine();
        // int magicNumber = int.Parse(answerMagicNumber);

        // Console.Write("What is your guess? ");
        // string answerGuessNumber = Console.ReadLine();
        // int guessNumber = int.Parse(answerGuessNumber);

        // if (magicNumber > guessNumber)
        // {
        //     Console.WriteLine("Higher");
        // }
        // else if (magicNumber < guessNumber)
        // {
        //     Console.WriteLine("Lower");
        // }
        // else
        // {
        //     Console.WriteLine("You guessed it!");
        // }


        //CORE REQUIREMENT #2 AND #3

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        int guessNumber = 0;

        while (magicNumber != guessNumber)
        {
            Console.Write("What is your guess? ");
            string answerGuessNumber = Console.ReadLine();
            guessNumber = int.Parse(answerGuessNumber);
            
            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }    

    }
}