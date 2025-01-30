using System;
using System.Drawing;

class Program
{
    Menu menu = new Menu();
    
    bool running = true;
    static void Main(string[] args)
    {
        PromptManager promptManager = new PromptManager();
        Journal journal = new Journal();

        string prompt = promptManager.GetRandPO();
        Console.WriteLine(prompt);
        string text = Console.ReadLine();

        journal.AddEntry(prompt, text);
        journal.Load("Default");
    }

    public void AddEntry()
    {

    }

    public void Load()
    {

    }

    public void Save()
    {

    }

    public void Cleanup()
    {

    }
}