using System.Xml;

class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (var job in _jobs)
        {
            job.Display();
        }
    }

    public void AddJob()
    {
        Console.Write("Job Title: ");
        string jobTitle = Console.ReadLine();
        Console.Write("Company: ");
        string company = Console.ReadLine();
        Console.Write("Start Year: ");
        string startYear = Console.ReadLine();
        Console.Write("End Year: ");
        string endYear = Console.ReadLine();

        Job newJob = new Job();
        newJob._jobTitle = jobTitle;
        newJob._company = company;
        newJob._startYear = startYear;
        newJob._endYear = endYear;

        _jobs.Add(newJob);
    }
}