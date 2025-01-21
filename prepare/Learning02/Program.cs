using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();
        resume._name = "Kyle Hicken";

        resume.AddJob();
        resume.Display();
    }
}