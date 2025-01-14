using System;

class Program
{
    static void Main(string[] args)
    {
        char letter;
        bool passing;

        string userInput;
        Console.Write("What is your percent on the course? ");
        userInput = Console.ReadLine();

        int percent = int.Parse(userInput);

        if (percent >= 90){
            letter = 'A';
            passing = true;
        }
        else if (percent >= 80){
            letter = 'B';
            passing = true;
        }
        else if (percent >= 70){
            letter = 'C';
            passing = true;
        }
        else if (percent >= 60){
            letter = 'D';
            passing = false;
        }
        else{
            letter = 'F';
            passing = false;
        }

        Console.WriteLine($"Your letter grade is {letter}");

        if (passing){
            Console.WriteLine("Congratulations on passing the course!!!");
        }
        else{
            Console.WriteLine("You can do even better next time.");
        }
    }
}