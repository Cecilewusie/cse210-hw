using System.IO;

public class Journal
{
    //This class will store a list of Entry objects/ Journal Entries
    List<Entry> _Entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        //we will use code such as theJournal.AddEntry(anEntry); to add newEntries to the Journal
        _Entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        //the Journal display method or DisplayAll will iterate through all Entry objects and call the Entry display method
        foreach (Entry e in _Entries)
        {
            e.DisplayEntry();
        }
        Console.WriteLine("Above are your entries..");
        
    }

    public void SaveToFile(string fileName)
    {   

        //this will save to a file by using the file name from the user
        using (StreamWriter outPutFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _Entries )
            {
                outPutFile.WriteLine($"{e._date}~~{e._entryText}~~{e._promtText}");
            }
        }
        Console.WriteLine($"saved to the file name: {fileName}");        

    }

    public void LoadFromFile(string fileName)
    {
        try
        {
            //clearing the old entries to fill them in with our loaded parts
            _Entries.Clear();

            //This will load data stored in already existing file
            string [] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string [] parts = line.Split("~~");
                string date = parts[0];
                string promptText = parts[1];
                string entryText = parts[2];
                
                //creating a new loadEntry object to load into our empty list _Entries
                Entry loadEntryObj = new Entry();
                loadEntryObj._date = date;
                loadEntryObj._entryText = promptText;
                loadEntryObj._promtText = entryText;
                _Entries.Add(loadEntryObj);
            }
            Console.WriteLine($"{fileName} is loaded successfully");
            Console.WriteLine("choose the dispay button to view");
        }
        catch (Exception e)
        {
            Console.WriteLine("The name of the file does not exist");
            Console.WriteLine("Enter a valid file name");
            Console.WriteLine();
            Console.WriteLine(e);
        }
    }
}