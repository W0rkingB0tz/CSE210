using System;

class Program
{
    static void Main(string[] args)
    {
        bool again = true;
        do
        {
            newGame();
            Console.WriteLine("\nDo you want to play again (y/n)? ");
            string input = Console.ReadLine();
            if (input == "n")
            {
                again = false;
            }
        } while (again != false);
    }

    static void newGame()
    {
        int guessAmount = 1;

        Random numberGenerator = new Random();
        int number = numberGenerator.Next(1,11);

        Console.Write("Guess the number 1-10: ");
        string input = Console.ReadLine();
        int guess = int.Parse(input);

        while (number != guess)
        {
            if (number < guess)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                input = Console.ReadLine();
                guess = int.Parse(input);
                guessAmount++;
            }
            else if (number > guess)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                input = Console.ReadLine();
                guess = int.Parse(input);
                guessAmount++;
            }
        }
        Console.WriteLine($"You guessed it!");
        Console.WriteLine($"You took {guessAmount} tries!");
    }
}