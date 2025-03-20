using System;
public class Resume
{
    public string _namePerson;
    public List<Job> _jobHistory = new List<Job>();

    public void DisplayResume()
    {
        Console.Write($"{_namePerson} ");
        foreach (Job job in _jobHistory)
        {
            job.DisplayJob();
        }
    }


}