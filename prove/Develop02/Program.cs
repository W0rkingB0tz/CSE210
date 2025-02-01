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
                running = Cleanup(journal);
            } else if (actionInput == "6"){
                DeleteFile();
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
        string file = $"{fileName}.txt";

        return file;
    }

    public static string Save()
    {
        Console.Write("File name to write to: ");
        string fileName = Console.ReadLine();
        string file = $"{fileName}.txt";

        return file;
    }

    public static bool Cleanup(Journal jounral)
    {
        if (jounral.changed == true)
        {
            Console.WriteLine("You have not saved the entries, please save first");
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void DeleteFile()
    {
        Console.WriteLine("Enter existing file name to delete: ");
        string fileName = Console.ReadLine();
        string file = $"{fileName}.txt";

        File.Delete(file);
        Console.WriteLine($"{file} has been deleted");
    }
}