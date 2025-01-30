class Journal
{
    List<Entry> entries = new List<Entry>();
    bool changed;

    public void Load(string fileName)
    {
        foreach (var entryChange in entries)
        {
            entryChange.Display();
        }
    }

    public void Save(string fileName)
    {
        
    }

    public void AddEntry(string prompt, string text)
    {
        Entry entry = new Entry();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        entry._date = dateText;
        entry._prompt = prompt;
        entry._text = text;

        entries.Add(entry);
    }
}