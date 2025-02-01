using System.Runtime.InteropServices.Marshalling;

class Journal
{
    List<Entry> entries = new List<Entry>();
    public bool changed;

    public void Load(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] entryData = line.Split("|");

            Entry entry = new Entry
            {
                _date = entryData[0],
                _prompt = entryData[1],
                _text = entryData[2]
            };

            entry.Display();
        }
    }

    public void Save(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._text}");
            }
        }

        changed = false;
    }

    public void AddJournalEntry(string prompt, string text)
    {
        Entry entry = new Entry();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        entry._date = dateText;
        entry._prompt = prompt;
        entry._text = text;

        entries.Add(entry);

        changed = true;
    }

    public void Display()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }
}