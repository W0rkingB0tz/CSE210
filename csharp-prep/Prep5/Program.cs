using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        double square = SquareNumber(userNumber);
        DisplayResult(userName, square);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        string userInputNumber = Console.ReadLine();
        int userNumber = int.Parse(userInputNumber);
        return userNumber;
    }

    static double SquareNumber(int userNumber){
        double square = Math.Pow(userNumber, 2);
        return square;
    }

    static void DisplayResult(string userName, double userNumber){
        Console.WriteLine($"{userName}, the sqaure of your number is {userNumber}");
    }
}