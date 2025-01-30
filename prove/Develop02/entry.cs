class Entry
{
    string _date;
    string _prompt;
    string _text;

    public void Display()
    {
        Console.WriteLine($"{_date}: {_prompt}\n{_text}");
    }
}