class Journal
{
    List<Entry> entries = new List<Entry>();
    bool changed;

    public void Load(string fileName)
    {

    }

    public void Save(string fileName)
    {
        
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
}