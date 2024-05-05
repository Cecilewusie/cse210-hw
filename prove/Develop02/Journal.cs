using System.IO;
public class Journal
{
    public List<Entry> _entry = new List<Entry>();
    public string _filename;


    public void SaveToFIle()
    {
        using (StreamWriter OutPutFIle = new StreamWriter(_filename))
        {
            Console.WriteLine("saving to a file...");
            foreach (Entry line in _entry)
            {
                List<string> savedItem = line._usersEntry;
                foreach (string row in savedItem)
                { 
                    OutPutFIle.WriteLine(row);
                }
            }
        }

    }


    public void ReadSavedFile()
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(_filename);
            Console.WriteLine("");
            Console.WriteLine("Retrieving your entries in the journal...");
            Console.WriteLine("");

            foreach (string line in lines)
            {
                string[] jounalText = line.Split("~~");

                foreach (string row in jounalText )
                {
                    Console.WriteLine(row);
                }
            }
        }
        catch (Exception e)
        {
            
            Console.WriteLine($"Opps!, There are no entries in this file, run it again and put entries to the journal");
            Console.WriteLine("");
            Console.WriteLine(e);
        }

    }   
}

