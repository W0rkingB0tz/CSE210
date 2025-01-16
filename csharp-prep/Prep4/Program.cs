using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        double sumTotal = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        while (number != 0){
            numbers.Add(number);
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
        }

        int largestNumber = 0;
        foreach (int index in numbers){
            sumTotal += index;
            if (index > largestNumber){
                largestNumber = index;
            }
        }

        double average = sumTotal / numbers.Count;
        Console.WriteLine($"The sum is: {sumTotal}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}