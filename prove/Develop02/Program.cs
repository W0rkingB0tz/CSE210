using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        Menu menu = new Menu();
        PromptManager promptManager = new PromptManager();
        Journal journal = new Journal();

        while (running)
        {
            menu.Display();
            Console.Write("\nEnter action: ");
            string actionInput = Console.ReadLine();

            if (actionInput == "1"){
                AddEntry(journal, promptManager);
            } else if (actionInput == "2"){
                string fileName = Save();
                journal.Save(fileName);
            } else if (actionInput == "3"){
                journal.Display();
            } else if (actionInput == "4"){
                string fileName = Load();
                journal.Load(fileName);
            } else if (actionInput == "5"){
                running = Cleanup();
            } else{
                Console.WriteLine("Invalid action!");
            }
        }
    }

    public static void AddEntry(Journal journal, PromptManager promptManager)
    {
        string prompt = promptManager.GetRandPO();
        Console.WriteLine(prompt);
        string text = Console.ReadLine();

        journal.AddJournalEntry(prompt, text);
    }

    public static string Load()
    {
        Console.Write("File name to read from: ");
        string fileName = Console.ReadLine();

        return fileName;
    }

    public static string Save()
    {
        Console.Write("File name to write to: ");
        string fileName = Console.ReadLine();

        return fileName;
    }

    public static bool Cleanup()
    {
        return false;
    }
}