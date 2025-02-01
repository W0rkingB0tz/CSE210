class Entry
{
    public string _date;
    public string _prompt;
    public string _text;

    public void Display()
    {
        Console.WriteLine($"{_date}: {_prompt}\n{_text}\n");
    }
}