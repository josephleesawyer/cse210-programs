using System;

public class Journal
{
    private List<Entry> _entryList = new();

    // public string JournalDisplay()
    // {
    //     string display = "";

    //     return display;
    // }
    public void DisplayJournal()
    {
        foreach (Entry entry in _entryList)
        {
            Console.WriteLine($"{entry.EntryDisplay()}\r\n\r\nPress Enter to Go To Next Entry. \r\n");
            Console.ReadLine();
        }

    }
    public void AddEntry()
    {
        Entry newEntry = new();
        _entryList.Add(newEntry);
    }
    public void SaveTo(string fileName)
    {
        using (StreamWriter destinationFile = new(fileName))
        {
            foreach (Entry entry in _entryList)
            {
                destinationFile.WriteLine(entry.SaveCode());
            } 
        }
    }
    public void LoadFrom(string fileName, bool overwrite)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        if (overwrite)
        {
            _entryList = new();
        }

        foreach (string line in lines)
        {
            Entry loadingEntry = new(line);
            _entryList.Add(loadingEntry);
        }
    }
    public void ClearEntries()
    {
        _entryList = new();
    }

}